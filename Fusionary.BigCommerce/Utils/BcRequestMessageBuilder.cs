namespace Fusionary.BigCommerce.Utils;

public static class BcRequestMessageBuilder
{
    public static HttpRequestMessage CreateRequestMessage(
        HttpMethod method,
        string path,
        QueryString queryString = default,
        BcRequestOptions? options = null
    )
    {
        var requestPath = path; 

        if (options?.RequestOverrides?.IsB2B ?? false)
        {
            requestPath = $"/api/{path}";
        } 
        else if (!string.IsNullOrWhiteSpace(options?.RequestOverrides?.StoreHash))
        {
            requestPath = $"/stores/{options.RequestOverrides.StoreHash}/{path}";
        }

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