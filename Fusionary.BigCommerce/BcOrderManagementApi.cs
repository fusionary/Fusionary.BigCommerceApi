namespace Fusionary.BigCommerce;

public class BcOrderManagementApi
{
    private readonly IBigCommerceApi _api;

    public BcOrderManagementApi(IBigCommerceApi api)
    {
        _api = api;
    }

    public BcOrdersSearch Search() => new (_api);
}