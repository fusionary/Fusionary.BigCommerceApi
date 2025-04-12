namespace Fusionary.BigCommerce.Operations;

public class BcApiProductMetafieldsGetAll(IBcApi api) : BcMetafieldsGetAllBase(api), IBcApiOperation

{
    protected override string MetafieldResourceEndpoint(BcId resourceId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId);
}