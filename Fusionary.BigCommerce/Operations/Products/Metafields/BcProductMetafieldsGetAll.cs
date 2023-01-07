namespace Fusionary.BigCommerce.Operations;

public class BcProductMetafieldsGetAll : BcMetafieldsGetAllBase

{
    public BcProductMetafieldsGetAll(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId);
}