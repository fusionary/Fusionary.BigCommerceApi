namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTreesGetCategoryTree : BcRequestBuilder,
    IBcApiOperation
{
    public BcApiCategoryTreesGetCategoryTree(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcCategoryTreePathItem[]>> SendAsync(
        BcId treeId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcCategoryTreePathItem>(treeId, cancellationToken);

    public async Task<BcResultData<T[]>> SendAsync<T>(BcId treeId, CancellationToken cancellationToken = default) =>
        await Api.GetDataAsync<T[]>(
            BcEndpoint.CategoryTreeCategoriesV3(treeId),
            Filter,
            Options,
            cancellationToken
        );
}