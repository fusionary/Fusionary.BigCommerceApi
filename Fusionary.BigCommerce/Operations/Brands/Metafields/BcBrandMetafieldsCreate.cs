namespace Fusionary.BigCommerce.Operations;

public class BcBrandMetafieldsCreate : BcMetafieldsCreateBase
{
    public BcBrandMetafieldsCreate(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(object resourceId) => BcEndpoint.BrandMetafieldsV3(resourceId);
}