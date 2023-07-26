namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// BigCommerce Catalog API Operations
/// </summary>
/// <remarks>
/// See https://developer.bigcommerce.com/api-reference/f176e7aec547a-catalog
/// </remarks>
public class BcApiCatalog : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiCatalog(IBcApi api)
    {
        _api = api;
    }

    public BcApiBrand Brand() => new(_api);

    public BcApiBrandImage BrandImages() => new(_api);

    public BcApiBrandMetafields BrandMetafields() => new(_api);

    public BcApiCategory Category() => new(_api);

    public BcApiCategoryTrees CategoryTrees() => new(_api);

    public BcApiCategoryImages CategoryImages() => new(_api);

    public BcApiCategoryMetafields CategoryMetafields() => new(_api);

    /// <summary>
    /// Products are the primary catalog entity, and the primary function of the ecommerce platform is to sell products
    /// on the storefront and other channels.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/ZG9jOjIyMDU5Ng-catalog-overview#products-overview
    /// </remarks>
    public BcApiProduct Product() => new(_api);

    public BcApiProductCustomFields ProductCustomFields() => new(_api);

    public BcApiProductCategoryAssignments ProductCategoryAssignments() => new(_api);

    public BcApiProductChannelAssignments ProductChannelAssignments() => new(_api);

    public BcApiProductImages ProductImages() => new(_api);

    public BcApiProductMetafields ProductMetafields() => new(_api);

    public BcApiProductModifiers ProductModifiers() => new(_api);

    public BcApiProductVariants ProductVariants() => new(_api);

    public BcApiSummary Summary() => new(_api);
}
