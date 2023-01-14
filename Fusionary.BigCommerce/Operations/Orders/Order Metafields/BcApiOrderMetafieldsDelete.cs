namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderMetafieldsDelete : BcMetafieldDeleteBase, IBcApiOperation
{
    public BcApiOrderMetafieldsDelete(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.OrderMetafieldsV3(resourceId, metafieldId);
}