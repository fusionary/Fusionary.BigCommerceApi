namespace Fusionary.BigCommerce.Operations;

public class BcOrderMetafieldsCreate : BcMetafieldsCreateBase
{
    public BcOrderMetafieldsCreate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId) => BcEndpoint.OrderMetafieldsV3(resourceId);
}