namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldsCreate(IBcApi api) : BcMetafieldsCreateBase(api), IBcApiOperation
{
    protected override string MetafieldResourceEndpoint(BcId resourceId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId);
}