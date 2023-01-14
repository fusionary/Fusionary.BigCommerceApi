namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldDelete : BcMetafieldDeleteBase, IBcApiOperation
{
    public BcCategoryMetafieldDelete(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId, metafieldId);
}