using System.Net.Http.Headers;

namespace Fusionary.BigCommerce.Utils;

public static class BcHttpClientUtil
{
    public static HttpClient ConfigureHttpClient(
        this HttpClient client,
        BigCommerceConfig config
    )
    {
        client.BaseAddress = new UriBuilder($"{config.Host}") { Path = $"/stores/{config.StoreHash}/" }.Uri;

        var headers = client.DefaultRequestHeaders;

        headers.TryAddWithoutValidation(BcHeaderName.XAuthToken, config.AccessToken);
        headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        return client;
    }
    
    public static HttpClient ConfigureB2BHttpClient(
        this HttpClient client,
        BigCommerceConfig config
    )
    {
        client.BaseAddress = new UriBuilder($"{config.B2BHost}") { Path = $"/api" }.Uri;

        var headers = client.DefaultRequestHeaders;

        headers.TryAddWithoutValidation(BcHeaderName.B2BAuthToken, config.B2BAccessToken);
        headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        return client;
    }
    
}