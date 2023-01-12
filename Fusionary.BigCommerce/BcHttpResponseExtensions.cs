using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;

namespace Fusionary.BigCommerce;

public static class BcHttpResponseExtensions
{
    public static bool DoesNotHaveContent(this HttpResponseMessage response) =>
        response.StatusCode == HttpStatusCode.NoContent || response.Content.Headers.ContentLength == 0;

    public static BcRateLimitResponseHeaders GetRateLimitHeaders(this HttpResponseMessage response)
    {
        response.TryGetHeaderValue<int>("X-Rate-Limit-Requests-Left", out var requestsLeft);
        response.TryGetHeaderValue<int>("X-Rate-Limit-Requests-Quota", out var requestsQuota);
        response.TryGetHeaderValue<int>("X-Rate-Limit-Time-Reset-Ms", out var timeResetMs);
        response.TryGetHeaderValue<int>("X-Rate-Limit-Time-Window-Ms", out var timeWindowMs);

        return new BcRateLimitResponseHeaders
        {
            RequestsLeft = requestsLeft,
            RequestsQuota = requestsQuota,
            TimeResetMs = timeResetMs,
            TimeWindowMs = timeWindowMs
        };
    }

    public static bool HasJsonContent(this HttpResponseMessage response) =>
        response.Content.Headers.ContentType?.MediaType?.Contains("json", StringComparison.OrdinalIgnoreCase) ?? false;

    public static async Task<BcErrorDetails?> ReadErrorFromResponseAsync(
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
            JsonValueKind.String => new BcErrorDetails
            {
                Title = root.ToString(), Type = "Unknown", Status = response.StatusCode
            },
            JsonValueKind.Object when root.TryGetProperty("status", out var _) &&
                                      root.TryGetProperty("title", out var _) =>
                root.Deserialize<BcErrorDetails>(BcJsonUtil.JsonOptions),
            _ => new BcErrorDetails { Status = response.StatusCode }
        };
    }

    public static async Task<BcResult<TResult, TMeta>> ReadErrorResponseAsync<TResult, TMeta>(
        this HttpResponseMessage response,
        CancellationToken cancellationToken
    )
    {
        var rateLimits = response.GetRateLimitHeaders();
        var error      = await response.ReadErrorFromResponseAsync(cancellationToken);

        return new BcResult<TResult, TMeta>
        {
            Success = false,
            StatusCode = response.StatusCode,
            Error = error!,
            RateLimits = rateLimits,
            ResponseText = await response.Content.ReadAsStringAsync(cancellationToken)
        };
    }

    public static async Task<BcResult<TData, TMeta>> ReadResponseAsync<TData, TMeta>(
        this HttpResponseMessage response,
        CancellationToken cancellationToken
    )
    {
        try
        {
            var result = await ReadResponseInternalAsync<TData, TMeta>(response, cancellationToken);

            return result;
        }
        catch (Exception ex)
        {
            return new BcResult<TData, TMeta>
            {
                Success = false,
                StatusCode = response.StatusCode,
                Error = new BcErrorDetails
                {
                    Title = "Error reading response",
                    Status = response.StatusCode,
                    Type = "Exception",
                    ErrorDetails = new Dictionary<string, string> { { "Exception", ex.ToString() } }
                },
                ResponseText = await response.Content.ReadAsStringAsync(cancellationToken)
            };
        }
    }

    private static async Task<BcResult<TData, TMeta>> ReadResponseInternalAsync<TData, TMeta>(
        HttpResponseMessage response,
        CancellationToken cancellationToken
    )
    {
        var rateLimits = response.GetRateLimitHeaders();

        if (response.DoesNotHaveContent())
        {
            return new BcResult<TData, TMeta>
            {
                Success = true, StatusCode = response.StatusCode, RateLimits = rateLimits
            };
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
                StatusCode = response.StatusCode,
                RateLimits = rateLimits,
                ResponseText = json.RootElement.GetRawText()
            };
        }
        
        root.TryGetProperty("data", out var dataProperty);
        root.TryGetProperty("meta", out var metaProperty);

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
            RateLimits = rateLimits,
            ResponseText = json.RootElement.GetRawText()
        };
    }

    public static bool TryGetHeaderValue<T>(
        this HttpResponseMessage response,
        string headerName,
        [NotNullWhen(true)] out T? headerValue
    )
    {
        headerValue = default;

        if (response.Headers.TryGetValues(headerName, out var values))
        {
            var value = values.FirstOrDefault();

            if (value is not null)
            {
                headerValue = value.As<T>();
            }
        }

        return headerValue is not null;
    }
}