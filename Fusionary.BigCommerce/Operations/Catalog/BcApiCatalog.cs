using Fusionary.BigCommerce.Operations.Product_Bulk_Pricing;

namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// BigCommerce Catalog API Operations
/// </summary>
/// <remarks>
/// See https://developer.bigcommerce.com/api-reference/f176e7aec547a-catalog
/// </remarks>
public class BcApiCatalog(IBcApi api) : IBcApiOperation
{
    public BcApiBrand Brand() => new(api);

    public BcApiCategory Category() => new(api);

    public BcApiCategoryTrees CategoryTrees() => new(api);

    /// <summary>
    /// Products are the primary catalog entity, and the primary function of the ecommerce platform is to sell products
    /// on the storefront and other channels.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/ZG9jOjIyMDU5Ng-catalog-overview#products-overview
    /// </remarks>
    public BcApiProduct Product() => new(api);

    public BcApiProductCategoryAssignments ProductCategoryAssignments() => new(api);

    public BcApiProductChannelAssignments ProductChannelAssignments() => new(api);

    public BcApiProductCustomFields ProductCustomFields() => new(api);

    public BcApiProductImages ProductImages() => new(api);

    public BcApiProductMetafields ProductMetafields() => new(api);

    public BcApiProductModifiers ProductModifiers() => new(api);

    public BcApiProductVariants ProductVariants() => new(api);
    
    public BcApiProductBulkPricing ProductBulkPricing() => new(api);

    public BcApiSummary Summary() => new(api);
}