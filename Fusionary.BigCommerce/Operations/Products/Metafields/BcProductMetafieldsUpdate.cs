namespace Fusionary.BigCommerce.Operations;

public class BcProductMetafieldsUpdate : BcMetafieldsUpdateBase
{
    public BcProductMetafieldsUpdate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId, object metafieldId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId, metafieldId);
}