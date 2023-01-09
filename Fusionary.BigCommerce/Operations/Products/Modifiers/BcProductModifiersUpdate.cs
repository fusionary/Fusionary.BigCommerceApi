namespace Fusionary.BigCommerce.Operations;

public class BcProductModifiersUpdate : BcRequestBuilder
{
    public BcProductModifiersUpdate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcModifier>> SendAsync(
        BcProductModifier modifier,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcModifier>(modifier.ProductId, modifier.Id, modifier, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        int productId,
        int modifierId,
        object modifier,
        CancellationToken cancellationToken
    ) =>
        Api.PutDataAsync<TResponse>(
            BcEndpoint.ProductModifiersV3(productId, modifierId),
            modifier,
            Filter,
            Options,
            cancellationToken
        );
}