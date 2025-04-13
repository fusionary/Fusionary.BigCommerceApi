namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderMetafieldsGet(IBcApi api) : BcMetafieldsGetBase(api), IBcApiOperation

{
    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.OrderMetafieldsV3(resourceId, metafieldId);
}