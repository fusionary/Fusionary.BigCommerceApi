namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandMetafieldsCreate : BcMetafieldsCreateBase, IBcApiOperation
{
    public BcApiBrandMetafieldsCreate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId) => BcEndpoint.BrandMetafieldsV3(resourceId);
}