namespace Fusionary.BigCommerce;

/// <summary>
/// BigCommerce Fluent API
/// </summary>
public class Bc
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Bc" /> class.
    /// </summary>
    /// <param name="api"></param>
    public Bc(IBigCommerceApi api)
    {
        Api = api;
    }

    /// <summary>
    /// The base configured HttpClient
    /// </summary>
    public IBigCommerceApi Api { get; }
}