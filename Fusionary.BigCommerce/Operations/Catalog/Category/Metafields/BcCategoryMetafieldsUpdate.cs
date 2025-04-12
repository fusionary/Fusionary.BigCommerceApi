namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldsUpdate(IBcApi api) : BcMetafieldsUpdateBase(api), IBcApiOperation
{
    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId, metafieldId);
}