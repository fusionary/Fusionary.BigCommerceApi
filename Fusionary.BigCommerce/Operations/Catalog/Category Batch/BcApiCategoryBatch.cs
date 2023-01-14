namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryBatch : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiCategoryBatch(IBcApi api)
    {
        _api = api;
    }
}