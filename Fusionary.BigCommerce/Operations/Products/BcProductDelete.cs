namespace Fusionary.BigCommerce.Operations;

public class BcProductDelete : BcRequestBuilder
{
    public BcProductDelete(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(object productId, CancellationToken cancellationToken) =>
        Api.DeleteAsync(BcEndpoint.ProductsV3(productId), Filter, Options, cancellationToken);
}