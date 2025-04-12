namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandMetafieldsUpdate(IBcApi api) : BcMetafieldsUpdateBase(api), IBcApiOperation
{
    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.BrandMetafieldsV3(resourceId, metafieldId);
}