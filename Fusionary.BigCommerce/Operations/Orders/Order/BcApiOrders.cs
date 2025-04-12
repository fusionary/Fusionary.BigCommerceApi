namespace Fusionary.BigCommerce.Operations;

public class BcApiOrders : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiOrders(IBcApi api)
    {
        _api = api;
    }

    public BcApiOrderArchive Archive() => new(_api);

    public BcApiOrdersCreate Create() => new(_api);

    public BcApiOrdersGet Get() => new(_api);

    public BcApiOrderGetWithConsignments GetWithConsignments() => new(_api);

    public BcApiOrdersSearch Search() => new(_api);

    public BcApiOrdersUpdate Update() => new(_api);
}