namespace Fusionary.BigCommerce.Operations;

public class BcProductsDelete : BcRequestBuilder
{
    public BcProductsDelete(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(object productId, CancellationToken cancellationToken) =>
        Api.DeleteAsync(BcEndpoint.ProductsV3(productId), Filter, Options, cancellationToken);
}