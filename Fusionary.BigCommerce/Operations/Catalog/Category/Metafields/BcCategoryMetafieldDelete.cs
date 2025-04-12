namespace Fusionary.BigCommerce.Operations;

public class BcCategoryMetafieldDelete(IBcApi api) : BcMetafieldDeleteBase(api), IBcApiOperation
{
    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.CategoryMetafieldsV3(resourceId, metafieldId);
}