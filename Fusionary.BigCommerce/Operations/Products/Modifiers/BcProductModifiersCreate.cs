namespace Fusionary.BigCommerce.Operations;

public class BcProductModifiersCreate : BcRequestBuilder
{
    public BcProductModifiersCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductModifier>> SendAsync(
        BcProductModifierPost modifier,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcProductModifier>(modifier.ProductId, modifier, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        int productId,
        object modifier,
        CancellationToken cancellationToken
    ) =>
        Api.PostDataAsync<TResponse>(
            BcEndpoint.ProductModifiersV3(productId),
            modifier,
            Filter,
            Options,
            cancellationToken
        );
}