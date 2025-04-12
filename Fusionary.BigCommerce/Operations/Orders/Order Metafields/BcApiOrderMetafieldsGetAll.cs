namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderMetafieldsGetAll(IBcApi api) : BcMetafieldsGetAllBase(api), IBcApiOperation

{
    protected override string MetafieldResourceEndpoint(BcId resourceId) =>
        BcEndpoint.OrderMetafieldsV3(resourceId);
}