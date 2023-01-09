namespace Fusionary.BigCommerce.Operations;

public class BcProductModifiersGet : BcRequestBuilder,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
    public BcProductModifiersGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductModifier>> SendAsync(
        object productId,
        object modifierId,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcProductModifier>(productId, modifierId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        object productId,
        object modifierId,
        CancellationToken cancellationToken
    ) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.ProductModifiersV3(productId, modifierId),
            Filter,
            Options,
            cancellationToken
        );
}