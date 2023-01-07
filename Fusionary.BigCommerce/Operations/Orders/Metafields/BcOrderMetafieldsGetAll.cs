namespace Fusionary.BigCommerce.Operations;

public class BcOrderMetafieldsGetAll : BcMetafieldsGetAllBase

{
    public BcOrderMetafieldsGetAll(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId) =>
        BcEndpoint.OrderMetafieldsV3(resourceId);
}