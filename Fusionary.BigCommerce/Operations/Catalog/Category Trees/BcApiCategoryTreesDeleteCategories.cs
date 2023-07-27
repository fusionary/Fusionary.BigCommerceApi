namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTreesDeleteCategories : BcRequestBuilder,
    IBcApiOperation,
    IBcCategoryTreeFilter
{
    public BcApiCategoryTreesDeleteCategories(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<T>(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.CategoryTreeCategoriesV3(),
            Filter,
            Options,
            cancellationToken
        );
}