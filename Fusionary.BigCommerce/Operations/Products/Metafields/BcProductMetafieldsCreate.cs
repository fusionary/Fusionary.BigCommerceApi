namespace Fusionary.BigCommerce.Operations;

public class BcProductMetafieldsCreate : BcMetafieldsCreateBase
{
    public BcProductMetafieldsCreate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId);
}