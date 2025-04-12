namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTrees : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiCategoryTrees(IBcApi api)
    {
        _api = api;
    }

    public BcApiCategoryTressCreateCategories CreateCategories() => new(_api);

    public BcApiCategoryTreesDeleteCategories DeleteCategories() => new(_api);

    public BcApiCategoryTreesDelete DeleteTrees() => new(_api);

    public BcApiCategoryTreesGetAllCategories GetAllCategories() => new(_api);

    public BcApiCategoryTreesGetAll GetAllTrees() => new(_api);

    public BcApiCategoryTreesGetCategoryTree GetCategoryTree() => new(_api);

    public BcApiCategoryTressUpdateCategories UpdateCategories() => new(_api);

    public BcApiCategoryTreesUpsert UpsertTrees() => new(_api);
}