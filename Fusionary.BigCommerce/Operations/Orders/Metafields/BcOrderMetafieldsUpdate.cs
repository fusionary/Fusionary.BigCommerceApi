namespace Fusionary.BigCommerce.Operations;

public class BcOrderMetafieldsUpdate : BcMetafieldsUpdateBase
{
    public BcOrderMetafieldsUpdate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId, object metafieldId) =>
        BcEndpoint.OrderMetafieldsV3(resourceId, metafieldId);
}