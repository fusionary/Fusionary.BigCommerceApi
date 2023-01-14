namespace Fusionary.BigCommerce.Operations;

public class BcApiProductModifiersGet : BcRequestBuilder,
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
    public BcApiProductModifiersGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductModifier>> SendAsync(
        BcId productId,
        BcId modifierId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductModifier>(productId, modifierId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        BcId productId,
        BcId modifierId,
        CancellationToken cancellationToken = default
    ) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.ProductModifiersV3(productId, modifierId),
            Filter,
            Options,
            cancellationToken
        );
}