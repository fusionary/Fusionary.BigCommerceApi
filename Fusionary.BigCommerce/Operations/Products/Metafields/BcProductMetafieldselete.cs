namespace Fusionary.BigCommerce.Operations;

public class BcProductMetafieldselete : BcMetafieldDeleteBase
{
    public BcProductMetafieldselete(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId, object metafieldId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId, metafieldId);
}