namespace Fusionary.BigCommerce.Operations;

public class BcApiProductVariantsDelete : BcRequestBuilder, IBcApiOperation
{
    public BcApiProductVariantsDelete(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(BcId productId, BcId variantId, CancellationToken cancellationToken = default) =>
        Api.DeleteAsync(BcEndpoint.ProductVariantsV3(productId, variantId), Filter, Options, cancellationToken);
}