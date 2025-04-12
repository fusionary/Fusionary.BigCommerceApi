namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandMetafieldsCreate(IBcApi api) : BcMetafieldsCreateBase(api), IBcApiOperation
{
    protected override string MetafieldResourceEndpoint(BcId resourceId) => BcEndpoint.BrandMetafieldsV3(resourceId);
}