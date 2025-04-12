namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// Returns a list of product Custom Fields
/// </summary>
public class BcApiProductCustomFieldsGetList(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcPageableFilter
{
    public Task<BcResultPaged<BcCustomField>> SendAsync(
        BcId productId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcCustomField>(productId, cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(BcId productId, CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.ProductCustomFieldsV3(productId),
            Filter,
            Options,
            cancellationToken
        );
}