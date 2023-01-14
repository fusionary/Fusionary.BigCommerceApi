namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandImage : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiBrandImage(IBcApi api)
    {
        _api = api;
    }
}