namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTreesGetAllCategories : BcRequestBuilder,
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcPageableFilter,
    IBcCategoryFilter,
    IBcCategoryTreeFilter
{
    public BcApiCategoryTreesGetAllCategories(IBcApi api) : base(api)
    { }

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