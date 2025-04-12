namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTreesGetAllCategories(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcPageableFilter,
    IBcCategoryFilter,
    IBcCategoryTreeFilter
{
    public Task<BcResultPaged<BcCategoryTreeCategory>> SendAsync(CancellationToken cancellationToken = default) =>
        SendAsync<BcCategoryTreeCategory>(cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.CategoryTreeCategoriesV3(),
            Filter,
            Options,
            cancellationToken
        );
}