namespace Fusionary.BigCommerce.Operations;

public class BcBrandMetafieldsGetAll : BcMetafieldsGetAllBase

{
    public BcBrandMetafieldsGetAll(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId) =>
        BcEndpoint.BrandMetafieldsV3(resourceId);
}