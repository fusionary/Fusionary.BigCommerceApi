namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderShipments(IBcApi api) : IBcApiOperation
{
    public BcApiOrderShipmentsCreate Create() => new(api);
    public BcApiOrderShipmentsGet Get() => new(api);
    public BcApiOrderShipmentsDelete Delete() => new(api);
}