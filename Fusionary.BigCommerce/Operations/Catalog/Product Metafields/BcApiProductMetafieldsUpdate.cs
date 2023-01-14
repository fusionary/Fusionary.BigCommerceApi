namespace Fusionary.BigCommerce.Operations;

public class BcApiProductMetafieldsUpdate : BcMetafieldsUpdateBase, IBcApiOperation
{
    public BcApiProductMetafieldsUpdate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId, metafieldId);
}