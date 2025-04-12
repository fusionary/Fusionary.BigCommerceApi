namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTrees(IBcApi api) : IBcApiOperation
{
    public BcApiCategoryTressCreateCategories CreateCategories() => new(api);

    public BcApiCategoryTreesDeleteCategories DeleteCategories() => new(api);

    public BcApiCategoryTreesDelete DeleteTrees() => new(api);

    public BcApiCategoryTreesGetAllCategories GetAllCategories() => new(api);

    public BcApiCategoryTreesGetAll GetAllTrees() => new(api);

    public BcApiCategoryTreesGetCategoryTree GetCategoryTree() => new(api);

    public BcApiCategoryTressUpdateCategories UpdateCategories() => new(api);

    public BcApiCategoryTreesUpsert UpsertTrees() => new(api);
}