namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandMetafieldsGetAll : BcMetafieldsGetAllBase, IBcApiOperation

{
    public BcApiBrandMetafieldsGetAll(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId) =>
        BcEndpoint.BrandMetafieldsV3(resourceId);
}