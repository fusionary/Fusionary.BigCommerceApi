namespace Fusionary.BigCommerce.Operations;

public class BcOrderMetafieldsGet : BcMetafieldsGetBase

{
    public BcOrderMetafieldsGet(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId, object metafieldId) =>
        BcEndpoint.OrderMetafieldsV3(resourceId, metafieldId);
}