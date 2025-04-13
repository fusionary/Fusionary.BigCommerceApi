namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderShipping(IBcApi api) : IBcApiOperation
{
    public BcApiOrderShippingGet Get() => new(api);
}