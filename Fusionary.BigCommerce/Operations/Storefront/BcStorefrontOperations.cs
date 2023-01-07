namespace Fusionary.BigCommerce.Operations;

public class BcStorefrontOperations
{
    private readonly IBcApi _api;

    public BcStorefrontOperations(IBcApi api)
    {
        _api = api;
    }

    public BcStorefrontTokenGet GetToken() => new(_api);
}