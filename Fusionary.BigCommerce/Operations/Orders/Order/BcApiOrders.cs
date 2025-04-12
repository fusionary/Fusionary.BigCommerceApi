namespace Fusionary.BigCommerce.Operations;

public class BcApiOrders(IBcApi api) : IBcApiOperation
{
    public BcApiOrderArchive Archive() => new(api);

    public BcApiOrdersCreate Create() => new(api);

    public BcApiOrdersGet Get() => new(api);

    public BcApiOrderGetWithConsignments GetWithConsignments() => new(api);

    public BcApiOrdersSearch Search() => new(api);

    public BcApiOrdersUpdate Update() => new(api);
}