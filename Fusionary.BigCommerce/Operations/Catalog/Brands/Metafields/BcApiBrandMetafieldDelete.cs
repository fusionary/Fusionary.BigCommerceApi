namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandMetafieldDelete(IBcApi api) : BcMetafieldDeleteBase(api), IBcApiOperation
{
    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.BrandMetafieldsV3(resourceId, metafieldId);
}