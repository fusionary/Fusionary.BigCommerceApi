namespace Fusionary.BigCommerce.Operations;

public class BcApiOrdersOverview(IBcApi api) : IBcApiOperation
{
    public BcApiOrders Order() => new(api);

    public BcApiOrderMetafields OrderMetafields() => new(api);

    public BcApiOrderProducts OrderProducts() => new(api);

    public BcApiOrderShipments OrderShipments() => new(api);

    public BcApiOrderShipping OrderShipping() => new(api);
}