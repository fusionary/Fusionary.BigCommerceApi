namespace Fusionary.BigCommerce.Operations;

public class BcApiProductMetafieldsDelete(IBcApi api) : BcMetafieldDeleteBase(api), IBcApiOperation
{
    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId, metafieldId);
}