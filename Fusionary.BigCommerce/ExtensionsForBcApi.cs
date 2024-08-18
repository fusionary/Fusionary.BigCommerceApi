namespace Fusionary.BigCommerce;

public static class ExtensionsForBcApi
{
    /// <summary>
    /// BigCommerce Catalog API.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// 
    public static BcApiCartsOverview Carts(this IBcApi bc) => new(bc);

    public static BcApiCatalog Catalog(this IBcApi bc) => new(bc);

    public static BcApiManagement Management(this IBcApi bc) => new(bc);

    public static BcApiOrdersOverview Orders(this IBcApi bc) => new(bc);

    public static BcApiStorefront Storefront(this IBcApi bc) => new(bc);

    public static BcApiWebhooks Webhooks(this IBcApi bc) => new(bc);
}
