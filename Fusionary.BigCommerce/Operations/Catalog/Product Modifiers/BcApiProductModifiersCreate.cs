namespace Fusionary.BigCommerce.Operations;

public class BcApiProductModifiersCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiProductModifiersCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductModifier>> SendAsync(
        BcProductModifierPost modifier,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductModifier>(modifier.ProductId, modifier, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        BcId productId,
        object modifier,
        CancellationToken cancellationToken = default
    ) =>
        Api.PostDataAsync<TResponse>(
            BcEndpoint.ProductModifiersV3(productId),
            modifier,
            Filter,
            Options,
            cancellationToken
        );
}