namespace Fusionary.BigCommerce.Operations;

public class BcApiCartsOverview : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiCartsOverview(IBcApi api)
    {
        _api = api;
    }

    public BcApiCart Cart() => new(_api);
     
}