namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldsCreate : BcMetafieldsCreateBase, IBcApiOperation
{
    public BcCategoryMetafieldsCreate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId);
}