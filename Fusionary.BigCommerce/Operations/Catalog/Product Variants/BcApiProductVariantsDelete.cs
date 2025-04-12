namespace Fusionary.BigCommerce.Operations;

public class BcApiProductVariantsDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResult> SendAsync(BcId productId, BcId variantId, CancellationToken cancellationToken = default) =>
        Api.DeleteAsync(BcEndpoint.ProductVariantsV3(productId, variantId), Filter, Options, cancellationToken);
}