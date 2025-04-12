namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTressCreateCategories(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcCategoryTreeCategory[]>> SendAsync(
        IEnumerable<BcCategoryTreePostItem> categories,
        CancellationToken cancellationToken = default
    ) =>
        Api.PostDataAsync<BcCategoryTreeCategory[]>(
            BcEndpoint.CategoryTreeCategoriesV3(),
            categories,
            Filter,
            Options,
            cancellationToken
        );
}