namespace Fusionary.BigCommerce;

public interface IBigCommerceClient
{
    HttpClient Client { get; }
    
    HttpClient B2BClient { get; }

    BigCommerceConfig Config { get; init; }
}