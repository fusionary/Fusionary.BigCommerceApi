namespace Fusionary.BigCommerce.Operations;

public class BcApiProductMetafieldsGet(IBcApi api) : BcMetafieldsGetBase(api), IBcApiOperation

{
    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId, metafieldId);
}