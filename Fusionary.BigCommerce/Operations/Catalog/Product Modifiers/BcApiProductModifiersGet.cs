namespace Fusionary.BigCommerce.Operations;

public class BcApiProductModifiersGet(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
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