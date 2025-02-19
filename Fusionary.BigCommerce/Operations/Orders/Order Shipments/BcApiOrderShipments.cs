namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderShipments : IBcApiOperation
{
    private readonly IBcApi _api;
    
    public BcApiOrderShipments(IBcApi api)
    {
        _api = api;
    }
    
    public BcApiOrderShipmentsCreate Create() => new(_api);
}