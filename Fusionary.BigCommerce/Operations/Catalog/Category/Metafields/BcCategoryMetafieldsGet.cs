namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldsGet(IBcApi api) : BcMetafieldsGetBase(api), IBcApiOperation

{
    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId, metafieldId);
}