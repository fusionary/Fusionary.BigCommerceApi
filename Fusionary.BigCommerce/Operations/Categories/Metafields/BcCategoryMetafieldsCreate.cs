namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldsCreate : BcMetafieldsCreateBase
{
    public BcCategoryMetafieldsCreate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId);
}