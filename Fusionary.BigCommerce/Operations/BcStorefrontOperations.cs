namespace Fusionary.BigCommerce.Operations;

public class BcStorefrontOperations
{
    private readonly IBigCommerceApi _api;

    public BcStorefrontOperations(IBigCommerceApi api)
    {
        _api = api;
    }
    
    public BcStorefrontTokenGet GetToken() => new(_api);
}