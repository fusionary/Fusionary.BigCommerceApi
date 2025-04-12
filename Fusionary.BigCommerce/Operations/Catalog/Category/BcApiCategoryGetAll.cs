namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryGetAll(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcPageableFilter,
    IBcCategoryFilter
{
    public Task<BcResultPaged<BcCategory>> SendAsync(CancellationToken cancellationToken = default) =>
        SendAsync<BcCategory>(cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.CategoryV3(),
            Filter,
            Options,
            cancellationToken
        );
}