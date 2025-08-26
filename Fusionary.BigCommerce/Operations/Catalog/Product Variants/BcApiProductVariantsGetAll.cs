namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// Returns a list of product Variants
/// </summary>
public class BcApiProductVariantsGetAll(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcPageableFilter
{
    public Task<BcResultPaged<BcProductVariant>> SendAsync(
        BcId productId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductVariant>(productId, cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(BcId productId, CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.ProductVariantsV3(productId),
            Filter,
            Options,
            cancellationToken
        );

    public async Task<BcResultPaged<T>> SendAsync<T>(CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.ProductVariantsBatch(),
            Filter,
            Options,
            cancellationToken
        );
}