namespace Fusionary.BigCommerce.Operations;

public class BcApiProductsDelete : BcRequestBuilder, IBcApiOperation
{
    public BcApiProductsDelete(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(BcId productId, CancellationToken cancellationToken = default) =>
        Api.DeleteAsync(BcEndpoint.ProductsV3(productId), Filter, Options, cancellationToken);
}