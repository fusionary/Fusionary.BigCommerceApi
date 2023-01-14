namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderProducts : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiOrderProducts(IBcApi api)
    {
        _api = api;
    }

    public BcApiOrderProductsGet Get() => new(_api);
}