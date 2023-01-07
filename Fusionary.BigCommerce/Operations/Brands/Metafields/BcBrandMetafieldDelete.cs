namespace Fusionary.BigCommerce.Operations;

public class BcBrandMetafieldDelete : BcMetafieldDeleteBase
{
    public BcBrandMetafieldDelete(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId, object metafieldId) =>
        BcEndpoint.BrandMetafieldsV3(resourceId, metafieldId);
}