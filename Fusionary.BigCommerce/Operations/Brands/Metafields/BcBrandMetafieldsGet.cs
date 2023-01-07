namespace Fusionary.BigCommerce.Operations;

public class BcBrandMetafieldsGet : BcMetafieldsGetBase

{
    public BcBrandMetafieldsGet(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId, object metafieldId) =>
        BcEndpoint.BrandMetafieldsV3(resourceId, metafieldId);
}