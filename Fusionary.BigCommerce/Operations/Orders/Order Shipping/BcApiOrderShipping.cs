namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderShipping : IBcApiOperation
{
    private readonly IBcApi _api;
    
    public BcApiOrderShipping(IBcApi api)
    {
        _api = api;
    }
    
    public BcApiOrderShippingGet Get() => new(_api);
    
    public BcApiOrderShippingCreate Create() => new(_api);
}