namespace Fusionary.BigCommerce.Operations;

public class BcProductModifiersDelete : BcRequestBuilder
{
    public BcProductModifiersDelete(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(object productId, object modifierId, CancellationToken cancellationToken) =>
        Api.DeleteAsync(BcEndpoint.ProductModifiersV3(productId, modifierId), Filter, Options, cancellationToken);
}