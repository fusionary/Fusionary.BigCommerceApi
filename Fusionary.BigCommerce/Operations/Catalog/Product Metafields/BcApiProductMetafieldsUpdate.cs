namespace Fusionary.BigCommerce.Operations;

public class BcApiProductMetafieldsUpdate(IBcApi api) : BcMetafieldsUpdateBase(api), IBcApiOperation
{
    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId, metafieldId);
}