namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldsGet : BcMetafieldsGetBase

{
    public BcCategoryMetafieldsGet(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId, object metafieldId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId, metafieldId);
}