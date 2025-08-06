using Microsoft.Extensions.Options;

namespace Fusionary.BigCommerce;

public class BigCommerceClient : IBigCommerceClient
{
    public BigCommerceClient(HttpClient b2cClient, HttpClient b2bClient, IOptions<BigCommerceConfig> options) : this(
        b2cClient,
        b2bClient,
        options.Value
    )
    { }

    private BigCommerceClient(HttpClient b2cClient, HttpClient b2bClient, BigCommerceConfig config)
    {
        Config = config;
        Client = b2cClient.ConfigureHttpClient(Config);
        B2BClient = b2bClient.ConfigureB2BHttpClient(Config);
    }

    public BigCommerceConfig Config { get; init; }

    public HttpClient Client { get; init; }
    
    public HttpClient B2BClient { get; init; }

    public static IBigCommerceClient Create(BigCommerceConfig config) =>
        Create(new HttpClient(), new HttpClient(), config);

    public static IBigCommerceClient Create(HttpClient b2cClient, HttpClient b2bClient, BigCommerceConfig config) =>
        new BigCommerceClient(b2cClient,b2bClient, config);
}