namespace Fusionary.BigCommerce;

public static class BcRequestMessageBuilder
{
    public static HttpRequestMessage CreateRequestMessage(
        HttpMethod method,
        string path,
        QueryString queryString = default
    )
    {
        if (queryString.HasValue)
        {
            path += queryString.ToUriComponent();
        }

        return new HttpRequestMessage(method, path);
    }
}