namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTressCreateCategories : BcRequestBuilder, IBcApiOperation
{
    public BcApiCategoryTressCreateCategories(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcCategoryTreeCategory[]>> SendAsync(
        IEnumerable<BcCategoryTreePostItem> categories,
        CancellationToken cancellationToken = default
    ) {

        return Api.PostDataAsync<BcCategoryTreeCategory[]>(
            BcEndpoint.CategoryTreeCategoriesV3(),
            categories,
            Filter,
            Options,
            cancellationToken
        );
    }
}
