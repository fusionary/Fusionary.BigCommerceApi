namespace Fusionary.BigCommerce.Operations;

public class BcApiProductMetafieldsGet : BcMetafieldsGetBase, IBcApiOperation

{
    public BcApiProductMetafieldsGet(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId, metafieldId);
}