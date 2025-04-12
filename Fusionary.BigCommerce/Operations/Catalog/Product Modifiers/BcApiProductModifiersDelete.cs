namespace Fusionary.BigCommerce.Operations;

public class BcApiProductModifiersDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResult> SendAsync(BcId productId, BcId modifierId, CancellationToken cancellationToken = default) =>
        Api.DeleteAsync(BcEndpoint.ProductModifiersV3(productId, modifierId), Filter, Options, cancellationToken);
}