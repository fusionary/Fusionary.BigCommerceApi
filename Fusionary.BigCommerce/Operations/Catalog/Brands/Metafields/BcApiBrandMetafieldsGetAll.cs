namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandMetafieldsGetAll(IBcApi api) : BcMetafieldsGetAllBase(api), IBcApiOperation

{
    protected override string MetafieldResourceEndpoint(BcId resourceId) =>
        BcEndpoint.BrandMetafieldsV3(resourceId);
}