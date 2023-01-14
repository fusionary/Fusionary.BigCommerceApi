namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryImages : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiCategoryImages(IBcApi api)
    {
        _api = api;
    }
}