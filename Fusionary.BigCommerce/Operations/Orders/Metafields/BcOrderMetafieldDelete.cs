namespace Fusionary.BigCommerce.Operations;

public class BcOrderMetafieldDelete : BcMetafieldDeleteBase
{
    public BcOrderMetafieldDelete(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId, object metafieldId) =>
        BcEndpoint.OrderMetafieldsV3(resourceId, metafieldId);
}