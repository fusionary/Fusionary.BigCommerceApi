namespace Fusionary.BigCommerce.Operations;

public record BcProductDelete : BcRequestBuilder<BcProductDelete>
{
    public BcProductDelete(IBigCommerceApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(int productId, CancellationToken cancellationToken) =>
        Api.DeleteAsync(BcEndpoint.ProductsV3(productId), Filter, cancellationToken);
}