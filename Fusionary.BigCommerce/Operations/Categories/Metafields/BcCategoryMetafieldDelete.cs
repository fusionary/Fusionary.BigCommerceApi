namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldDelete : BcMetafieldDeleteBase
{
    public BcCategoryMetafieldDelete(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId, object metafieldId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId, metafieldId);
}