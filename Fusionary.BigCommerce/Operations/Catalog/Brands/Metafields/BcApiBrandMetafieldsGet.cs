namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandMetafieldsGet(IBcApi api) : BcMetafieldsGetBase(api), IBcApiOperation

{
    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.BrandMetafieldsV3(resourceId, metafieldId);
}