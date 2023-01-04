using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

using Fusionary.BigCommerce.Utils;

namespace Fusionary.BigCommerce;

public static class BcHttpResponseExtensions
{
    public static bool DoesNotHaveContent(this HttpResponseMessage response) =>
        response.StatusCode == HttpStatusCode.NoContent || response.Content.Headers.ContentLength == 0;

    public static bool HasJsonContent(this HttpResponseMessage response) =>
        response.Content.Headers.ContentType?.MediaType?.Contains("json", StringComparison.OrdinalIgnoreCase) ?? false;

    public static async Task<BcErrorBase?> ReadErrorFromResponseAsync(
        this HttpResponseMessage response,
        CancellationToken cancellationToken
    )
    {
        if (!response.HasJsonContent())
        {
            return default;
        }

        var json = await response.Content
            .ReadFromJsonAsync<JsonDocument>(BcJsonUtil.JsonOptions, cancellationToken);

        if (json is null)
        {
            throw new BcApiException("Unable to read JSON response");
        }

        var root = json.RootElement;

        return root.ValueKind switch
        {
            JsonValueKind.String => new BcErrorDetails { Title = root.ToString(), Status = response.StatusCode },
            JsonValueKind.Object when root.GetProperty("status").ValueKind != JsonValueKind.Undefined &&
                                      root.GetProperty("title").ValueKind != JsonValueKind.Undefined =>
                root.Deserialize<BcErrorDetails>(BcJsonUtil.JsonOptions),
            _ => new BcErrorDetails { Status = response.StatusCode }
        };
    }

    public static async Task<BcResult<TResult, TMeta>> ReadErrorResponseAsync<TResult, TMeta>(
        this HttpResponseMessage response,
        CancellationToken cancellationToken
    )
    {
        var error = await response.ReadErrorFromResponseAsync(cancellationToken);

        return new BcResult<TResult, TMeta>
        {
            Success = false,
            StatusCode = response.StatusCode,
            Error = error,
            ResponseText = await response.Content.ReadAsStringAsync(cancellationToken)
        };
    }

    public static async Task<BcResult<TData, TMeta>> ReadResponseAsync<TData, TMeta>(
        this HttpResponseMessage response,
        CancellationToken cancellationToken
    )
    {
        if (response.DoesNotHaveContent())
        {
            return new BcResult<TData, TMeta> { Success = true, StatusCode = response.StatusCode };
        }

        var json = await response.Content.ReadFromJsonAsync<JsonDocument>(BcJsonUtil.JsonOptions, cancellationToken);

        if (json is null)
        {
            throw new BcApiException("Unable to read JSON response");
        }

        var root = json.RootElement;

        if (root.ValueKind == JsonValueKind.Array)
        {
            var arrayData = root.Deserialize<TData>(BcJsonUtil.JsonOptions);

            return new BcResult<TData, TMeta>
            {
                Success = true,
                Data = arrayData!,
                Meta = default!,
                StatusCode = response.StatusCode,
                ResponseText = json.RootElement.GetRawText()
            };
        }

        var dataProperty = root.GetProperty("data");
        var metaProperty = root.GetProperty("meta");

        var meta = metaProperty.ValueKind == JsonValueKind.Undefined
            ? default
            : metaProperty.Deserialize<TMeta>(BcJsonUtil.JsonOptions);

        var data = dataProperty.ValueKind == JsonValueKind.Undefined
            ? root.Deserialize<TData>(BcJsonUtil.JsonOptions)
            : dataProperty.Deserialize<TData>(BcJsonUtil.JsonOptions);

        return new BcResult<TData, TMeta>
        {
            Success = true,
            Data = data!,
            Meta = meta!,
            StatusCode = response.StatusCode,
            ResponseText = json.RootElement.GetRawText()
        };
    }
}