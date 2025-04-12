namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTreesDeleteCategories(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcCategoryTreeFilter
{
    public async Task<BcResult> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.CategoryTreeCategoriesV3(),
            Filter,
            Options,
            cancellationToken
        );
}