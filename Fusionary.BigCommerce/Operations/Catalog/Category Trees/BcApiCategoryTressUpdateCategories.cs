namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTressUpdateCategories(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcCategoryTreeCategory[]>> SendAsync(
        IEnumerable<BcCategoryTreePutItem> categories,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcCategoryTreeCategory[]>(categories, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        IEnumerable<object> categories,
        CancellationToken cancellationToken = default
    ) =>
        await Api.PutDataAsync<T>(
            BcEndpoint.CategoryTreeCategoriesV3(),
            categories,
            Filter,
            Options,
            cancellationToken
        );
}