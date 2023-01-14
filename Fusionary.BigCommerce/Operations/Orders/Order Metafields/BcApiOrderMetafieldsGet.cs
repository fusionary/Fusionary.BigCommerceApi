namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderMetafieldsGet : BcMetafieldsGetBase, IBcApiOperation

{
    public BcApiOrderMetafieldsGet(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.OrderMetafieldsV3(resourceId, metafieldId);
}