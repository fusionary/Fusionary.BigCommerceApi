namespace Fusionary.BigCommerce.Operations;

public class BcApiProductVariantsGet(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
    public Task<BcResultData<BcProductVariant>> SendAsync(
        BcId productId,
        BcId variantId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductVariant>(productId, variantId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        BcId productId,
        BcId variantId,
        CancellationToken cancellationToken = default
    ) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.ProductVariantsV3(productId, variantId),
            Filter,
            Options,
            cancellationToken
        );
}