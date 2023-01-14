namespace Fusionary.BigCommerce.Operations;

public class BcApiProductModifiersDelete : BcRequestBuilder, IBcApiOperation
{
    public BcApiProductModifiersDelete(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(BcId productId, BcId modifierId, CancellationToken cancellationToken = default) =>
        Api.DeleteAsync(BcEndpoint.ProductModifiersV3(productId, modifierId), Filter, Options, cancellationToken);
}