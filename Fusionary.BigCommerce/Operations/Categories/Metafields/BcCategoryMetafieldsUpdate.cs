namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldsUpdate : BcMetafieldsUpdateBase
{
    public BcCategoryMetafieldsUpdate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId, object metafieldId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId, metafieldId);
}