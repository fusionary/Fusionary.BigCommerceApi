namespace Fusionary.BigCommerce.Operations;

public class BcApiProductMetafieldsCreate(IBcApi api) : BcMetafieldsCreateBase(api), IBcApiOperation
{
    protected override string MetafieldResourceEndpoint(BcId resourceId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId);
}