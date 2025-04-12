namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldsGetAll(IBcApi api) : BcMetafieldsGetAllBase(api), IBcApiOperation

{
    protected override string MetafieldResourceEndpoint(BcId resourceId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId);
}