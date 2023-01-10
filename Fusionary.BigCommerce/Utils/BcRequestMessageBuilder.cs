namespace Fusionary.BigCommerce.Utils;

public static class BcRequestMessageBuilder
{
    public static HttpRequestMessage CreateRequestMessage(
        HttpMethod method,
        string path,
        QueryString queryString = default,
        BcRequestOptions? options = default
    )
    {
        var requestPath = !string.IsNullOrWhiteSpace(options?.RequestOverrides?.StoreHash)
            ? $"/stores/{options.RequestOverrides.StoreHash}/{path}"
            : path;

        if (queryString.HasValue)
        {
            requestPath += queryString.ToUriComponent();
        }

        var requestMessage = new HttpRequestMessage(method, requestPath);

        if (options?.RequestOverrides?.HasHeaders == true)
        {
            var requestHeaders = requestMessage.Headers;

            foreach (var (key, value) in options.RequestOverrides.Headers)
            {
                requestHeaders.Remove(key);
                requestHeaders.TryAddWithoutValidation(key, value);
            }
        }

        return requestMessage;
    }
}