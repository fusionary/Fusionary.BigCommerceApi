namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderMetafieldsCreate : BcMetafieldsCreateBase, IBcApiOperation
{
    public BcApiOrderMetafieldsCreate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId) => BcEndpoint.OrderMetafieldsV3(resourceId);
}