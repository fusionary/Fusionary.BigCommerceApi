namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldsGet : BcMetafieldsGetBase, IBcApiOperation

{
    public BcCategoryMetafieldsGet(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId, metafieldId);
}