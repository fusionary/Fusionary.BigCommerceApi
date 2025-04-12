namespace Fusionary.BigCommerce.Operations;

public class BcApiOrdersOverview : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiOrdersOverview(IBcApi api)
    {
        _api = api;
    }

    public BcApiOrders Order() => new(_api);

    public BcApiOrderMetafields OrderMetafields() => new(_api);

    public BcApiOrderProducts OrderProducts() => new(_api);

    public BcApiOrderShipments OrderShipments() => new(_api);

    public BcApiOrderShipping OrderShipping() => new(_api);
}