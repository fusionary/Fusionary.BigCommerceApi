namespace Fusionary.BigCommerce;

public class BcProductDelete : BcRequestBuilder<BcProductDelete>
{
    public BcProductDelete(IBigCommerceApi api) : base(api)
    {
    }

    public Task<bool> SendAsync(int productId, CancellationToken cancellationToken) =>
        Api.DeleteAsync(BcEndpoint.ProductsV3(productId), Filter, cancellationToken);
}