namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderMetafieldsUpdate : BcMetafieldsUpdateBase, IBcApiOperation
{
    public BcApiOrderMetafieldsUpdate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.OrderMetafieldsV3(resourceId, metafieldId);
}