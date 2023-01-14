namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandMetafieldDelete : BcMetafieldDeleteBase, IBcApiOperation
{
    public BcApiBrandMetafieldDelete(IBcApi api) : base(api)
    { }

    protected override string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId) =>
        BcEndpoint.BrandMetafieldsV3(resourceId, metafieldId);
}