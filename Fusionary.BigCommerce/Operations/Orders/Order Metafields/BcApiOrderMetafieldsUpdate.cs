namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderMetafieldsUpdate(IBcApi api) : BcMetafieldsUpdateBase(api), IBcApiOperation
{
    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.OrderMetafieldsV3(resourceId, metafieldId);
}