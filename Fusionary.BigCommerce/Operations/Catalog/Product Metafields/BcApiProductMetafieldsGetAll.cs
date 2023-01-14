namespace Fusionary.BigCommerce.Operations;

public class BcApiProductMetafieldsGetAll : BcMetafieldsGetAllBase, IBcApiOperation

{
    public BcApiProductMetafieldsGetAll(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId) =>
        BcEndpoint.ProductMetafieldsV3(resourceId);
}