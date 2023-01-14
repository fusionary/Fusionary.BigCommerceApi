namespace Fusionary.BigCommerce.Operations;

public class BcApiStorefront : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiStorefront(IBcApi api)
    {
        _api = api;
    }

    public BcStorefrontTokenGet GetToken() => new(_api);
}