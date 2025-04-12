namespace Fusionary.BigCommerce.Operations;

public class BcApiProductModifiersUpdate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcModifier>> SendAsync(
        BcProductModifier modifier,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcModifier>(modifier.ProductId, modifier.Id, modifier, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        BcId productId,
        BcId modifierId,
        object modifier,
        CancellationToken cancellationToken = default
    ) =>
        Api.PutDataAsync<TResponse>(
            BcEndpoint.ProductModifiersV3(productId, modifierId),
            modifier,
            Filter,
            Options,
            cancellationToken
        );
}