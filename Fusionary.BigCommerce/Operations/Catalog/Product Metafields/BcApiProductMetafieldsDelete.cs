namespace Fusionary.BigCommerce.Operations;

public class BcApiProductMetafieldsDelete : BcMetafieldDeleteBase, IBcApiOperation
{
    public BcApiProductMetafieldsDelete(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId, metafieldId);
}