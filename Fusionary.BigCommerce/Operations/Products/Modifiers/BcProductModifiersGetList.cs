namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// Returns a list of product modifiers
/// </summary>
public class BcProductModifiersGetList : BcRequestBuilder,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcPageableFilter
{
    public BcProductModifiersGetList(IBcApi api) : base(api)
    { }

    public Task<BcResultPaged<BcProductModifier>> SendAsync(object productId, CancellationToken cancellationToken) =>
        SendAsync<BcProductModifier>(productId, cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(object productId, CancellationToken cancellationToken) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.ProductModifiersV3(productId),
            Filter,
            Options,
            cancellationToken
        );
}