using Microsoft.Extensions.Options;

namespace Fusionary.BigCommerce;

public class BigCommerceClient : IBigCommerceClient
{
    public BigCommerceClient(HttpClient httpClient, IOptions<BigCommerceConfig> options) : this(
        httpClient,
        options.Value
    )
    { }

    private BigCommerceClient(HttpClient httpClient, BigCommerceConfig config)
    {
        Config = config;
        Client = httpClient.ConfigureHttpClient(Config);
    }

    public BigCommerceConfig Config { get; init; }

    public HttpClient Client { get; init; }

    public static IBigCommerceClient Create(BigCommerceConfig config) =>
        Create(new HttpClient(), config);

    public static IBigCommerceClient Create(HttpClient httpClient, BigCommerceConfig config) =>
        new BigCommerceClient(httpClient, config);
}