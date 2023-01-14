namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandMetafieldsGet : BcMetafieldsGetBase, IBcApiOperation

{
    public BcApiBrandMetafieldsGet(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.BrandMetafieldsV3(resourceId, metafieldId);
}