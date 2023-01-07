namespace Fusionary.BigCommerce.Operations;

public class BcBrandMetafieldsUpdate : BcMetafieldsUpdateBase
{
    public BcBrandMetafieldsUpdate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId, object metafieldId) =>
        BcEndpoint.BrandMetafieldsV3(resourceId, metafieldId);
}