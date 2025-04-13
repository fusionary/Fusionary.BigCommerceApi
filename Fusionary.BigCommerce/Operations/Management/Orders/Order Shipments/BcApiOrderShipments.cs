namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderShipments(IBcApi api) : IBcApiOperation
{
    public BcApiOrderShipmentsCreate Create() => new(api);
}