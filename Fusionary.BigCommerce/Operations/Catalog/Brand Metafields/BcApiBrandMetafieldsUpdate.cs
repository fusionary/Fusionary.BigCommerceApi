namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandMetafieldsUpdate : BcMetafieldsUpdateBase, IBcApiOperation
{
    public BcApiBrandMetafieldsUpdate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.BrandMetafieldsV3(resourceId, metafieldId);
}