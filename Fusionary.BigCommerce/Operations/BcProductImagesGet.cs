namespace Fusionary.BigCommerce.Operations;

public record BcProductImagesGet: BcRequestBuilder<BcProductImagesGet>
{
    public BcProductImagesGet(IBigCommerceApi api) : base(api)
    {
    }
}