namespace Fusionary.BigCommerce;

public interface IBigCommerceClient
{
    HttpClient Client { get; }

    BigCommerceConfig Config { get; init; }
}