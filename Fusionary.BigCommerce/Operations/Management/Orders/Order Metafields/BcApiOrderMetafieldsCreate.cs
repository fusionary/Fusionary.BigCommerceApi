namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderMetafieldsCreate(IBcApi api) : BcMetafieldsCreateBase(api), IBcApiOperation
{
    protected override string MetafieldResourceEndpoint(BcId resourceId) => BcEndpoint.OrderMetafieldsV3(resourceId);
}