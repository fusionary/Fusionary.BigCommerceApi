namespace Fusionary.BigCommerce.Operations;

public class BcApiProductMetafieldsCreate : BcMetafieldsCreateBase, IBcApiOperation
{
    public BcApiProductMetafieldsCreate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId);
}