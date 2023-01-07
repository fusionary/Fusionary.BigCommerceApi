namespace Fusionary.BigCommerce.Operations;

public class BcCategoryGetAll : BcRequestBuilder,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcPageableFilter,
    IBcCategoryFilter
{
    internal BcCategoryGetAll(IBcApi api) : base(api)
    { }

    public Task<BcResultPaged<BcCategory>> SendAsync(CancellationToken cancellationToken) =>
        SendAsync<BcCategory>(cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(CancellationToken cancellationToken) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.CategoriesV3(),
            Filter,
            Options,
            cancellationToken
        );
}