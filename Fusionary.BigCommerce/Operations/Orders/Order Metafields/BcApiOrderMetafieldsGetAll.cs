namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderMetafieldsGetAll : BcMetafieldsGetAllBase, IBcApiOperation

{
    public BcApiOrderMetafieldsGetAll(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId) =>
        BcEndpoint.OrderMetafieldsV3(resourceId);
}