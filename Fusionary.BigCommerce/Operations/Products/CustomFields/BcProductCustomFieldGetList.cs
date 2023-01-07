namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// Returns a list of product Custom Fields
/// </summary>
public class BcProductCustomFieldGetList : BcRequestBuilder,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcPageableFilter
{
    public BcProductCustomFieldGetList(IBcApi api) : base(api)
    { }

    public Task<BcResultPaged<BcCustomField>> SendAsync(int productId, CancellationToken cancellationToken) =>
        SendAsync<BcCustomField>(productId, cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(int productId, CancellationToken cancellationToken) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.ProductCustomFieldsV3(productId),
            Filter,
            Options,
            cancellationToken
        );
}