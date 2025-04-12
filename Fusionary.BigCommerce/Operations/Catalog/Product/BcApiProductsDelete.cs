namespace Fusionary.BigCommerce.Operations;

public class BcApiProductsDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResult> SendAsync(BcId productId, CancellationToken cancellationToken = default) =>
        Api.DeleteAsync(BcEndpoint.ProductsV3(productId), Filter, Options, cancellationToken);
}