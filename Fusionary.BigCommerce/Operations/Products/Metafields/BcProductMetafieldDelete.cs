namespace Fusionary.BigCommerce.Operations;

public class BcProductMetafieldDelete : BcMetafieldDeleteBase
{
    public BcProductMetafieldDelete(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId, object metafieldId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId, metafieldId);
}