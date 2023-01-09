namespace Fusionary.BigCommerce;

public static class BcApiExtensions
{
    public static BcBrandOperations Brands(this IBcApi bc) => new(bc);

    /// <summary>
    /// BigCommerce Catalog Summary.
    /// </summary>
    public static BcSummaryOperations CatalogSummary(this IBcApi bc) => new(bc);

    public static BcCategoryOperations Categories(this IBcApi bc) => new(bc);

    public static BcOrderOperations Orders(this IBcApi bc) => new(bc);

    /// <summary>
    /// Products are the primary catalog entity, and the primary function of the ecommerce platform is to sell products
    /// on the storefront and other channels.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/ZG9jOjIyMDU5Ng-catalog-overview#products-overview
    /// </remarks>
    public static BcProductOperations Products(this IBcApi bc) => new(bc);

    public static BcStorefrontOperations Storefront(this IBcApi bc) => new(bc);
}