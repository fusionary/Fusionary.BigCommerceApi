namespace Fusionary.BigCommerce;

public class BcCreate
{
    private readonly IBigCommerceApi _api;

    public BcCreate(IBigCommerceApi api)
    {
        _api = api;
    }
}