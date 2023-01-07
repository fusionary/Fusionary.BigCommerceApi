namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldsGetAll : BcMetafieldsGetAllBase

{
    public BcCategoryMetafieldsGetAll(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId);
}