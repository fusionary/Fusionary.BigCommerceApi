namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryGetAll : BcRequestBuilder,
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcPageableFilter,
    IBcCategoryFilter
{
    public BcApiCategoryGetAll(IBcApi api) : base(api)
    { }

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