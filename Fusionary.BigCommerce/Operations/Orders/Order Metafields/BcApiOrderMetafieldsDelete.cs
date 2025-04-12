namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderMetafieldsDelete(IBcApi api) : BcMetafieldDeleteBase(api), IBcApiOperation
{
    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.OrderMetafieldsV3(resourceId, metafieldId);
}