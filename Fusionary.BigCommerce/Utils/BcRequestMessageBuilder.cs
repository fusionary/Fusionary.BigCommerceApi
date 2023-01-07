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
        var requestPath = string.IsNullOrWhiteSpace(options?.RequestOverrides.StoreHash)
            ? path
            : $"/stores/{options.RequestOverrides.StoreHash}/{path}";

        if (queryString.HasValue)
        {
            requestPath += queryString.ToUriComponent();
        }

        var requestMessage = new HttpRequestMessage(method, requestPath);

        if (!string.IsNullOrWhiteSpace(options?.RequestOverrides.AccessToken))
        {
            var headers = requestMessage.Headers;

            headers.Remove("X-Auth-Token");
            headers.TryAddWithoutValidation("X-Auth-Token", options.RequestOverrides.AccessToken);
        }

        return requestMessage;
    }
}