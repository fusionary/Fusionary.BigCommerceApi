namespace Fusionary.BigCommerce;

public class BcCategoryManagementApi
{
    private readonly IBigCommerceApi _api;

    public BcCategoryManagementApi(IBigCommerceApi api)
    {
        _api = api;
    }

    public BcCategoriesSearch Search() => new (_api);
}