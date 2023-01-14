namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldsUpdate : BcMetafieldsUpdateBase, IBcApiOperation
{
    public BcCategoryMetafieldsUpdate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId, metafieldId);
}