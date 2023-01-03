namespace Fusionary.BigCommerce.Operations;

public class BcCategoryOperations
{
    private readonly IBigCommerceApi _api;

    public BcCategoryOperations(IBigCommerceApi api)
    {
        _api = api;
    }

    public BcCategoriesSearch Search() => new(_api);
}