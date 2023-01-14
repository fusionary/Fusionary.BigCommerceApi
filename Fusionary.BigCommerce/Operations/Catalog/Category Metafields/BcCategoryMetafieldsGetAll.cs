namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldsGetAll : BcMetafieldsGetAllBase, IBcApiOperation

{
    public BcCategoryMetafieldsGetAll(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId);
}