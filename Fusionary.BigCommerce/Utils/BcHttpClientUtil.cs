using System.Net.Http.Headers;

namespace Fusionary.BigCommerce.Utils;

public static class BcHttpClientUtil
{
    public static HttpClient ConfigureHttpClient(
        this HttpClient client,
        BigCommerceConfig config
    )
    {
        client.BaseAddress = new UriBuilder($"{config.Host}")
        {
            Scheme = Uri.UriSchemeHttps, Path = $"/stores/{config.StoreHash}/"
        }.Uri;

        var headers = client.DefaultRequestHeaders;

        headers.TryAddWithoutValidation("X-Auth-Token", config.AccessToken);
        headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        return client;
    }
}