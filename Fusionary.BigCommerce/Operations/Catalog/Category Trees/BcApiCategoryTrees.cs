namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTrees : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiCategoryTrees(IBcApi api)
    {
        _api = api;
    }

    public BcApiCategoryTreesGetAll GetAllTrees() => new(_api);

    public BcApiCategoryTreesUpsert UpsertTrees() => new(_api);

    public BcApiCategoryTreesDelete DeleteTrees() => new(_api);

    public BcApiCategoryTreesGetAllCategories GetAllCategories() => new(_api);

    public BcApiCategoryTreesGetCategoryTree GetCategoryTree() => new(_api);
}

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
            BcEndpoint.CategoryTreesV3(),
            Filter,
            Options,
            cancellationToken
        );
}

public class BcApiCategoryTreesGetCategoryTree : BcRequestBuilder,
    IBcApiOperation
{
    public BcApiCategoryTreesGetCategoryTree(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcCategoryTreePathItem[]>> SendAsync(BcId treeId, CancellationToken cancellationToken = default) =>
        SendAsync<BcCategoryTreePathItem>(treeId, cancellationToken);

    public async Task<BcResultData<T[]>> SendAsync<T>(BcId treeId, CancellationToken cancellationToken = default) =>
        await Api.GetDataAsync<T[]>(
            BcEndpoint.CategoryTreesV3(treeId),
            Filter,
            Options,
            cancellationToken
        );
}
