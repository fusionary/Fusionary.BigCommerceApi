namespace Fusionary.BigCommerce.Operations;

public class BcApiCategorySortOrder : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiCategorySortOrder(IBcApi api)
    {
        _api = api;
    }
}
