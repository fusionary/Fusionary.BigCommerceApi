namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// Returns a list of product modifiers
/// </summary>
public class BcApiProductModifiersGetAll(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcPageableFilter
{
    public Task<BcResultPaged<BcProductModifier>> SendAsync(
        BcId productId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductModifier>(productId, cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(BcId productId, CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.ProductModifiersV3(productId),
            Filter,
            Options,
            cancellationToken
        );
}