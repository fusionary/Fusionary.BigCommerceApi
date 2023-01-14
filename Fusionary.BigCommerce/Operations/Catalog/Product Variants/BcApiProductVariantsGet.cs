namespace Fusionary.BigCommerce.Operations;

public class BcApiProductVariantsGet : BcRequestBuilder,
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
    public BcApiProductVariantsGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductVariant>> SendAsync(
        BcId productId,
        BcId VariantId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductVariant>(productId, VariantId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        BcId productId,
        BcId VariantId,
        CancellationToken cancellationToken = default
    ) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.ProductVariantsV3(productId, VariantId),
            Filter,
            Options,
            cancellationToken
        );
}