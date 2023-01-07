namespace Fusionary.BigCommerce.Operations;

public class BcProductMetafieldsGet : BcMetafieldsGetBase

{
    public BcProductMetafieldsGet(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId, object metafieldId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId, metafieldId);
}