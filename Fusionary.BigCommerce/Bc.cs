namespace Fusionary.BigCommerce;

/// <summary>
/// BigCommerce Fluent API
/// </summary>
public class Bc
{
    public Bc(IBigCommerceApi api)
    {
        Api = api;
    }


    /// <summary>
    /// The base configured HttpClient
    /// </summary>
    public IBigCommerceApi Api { get; }
}