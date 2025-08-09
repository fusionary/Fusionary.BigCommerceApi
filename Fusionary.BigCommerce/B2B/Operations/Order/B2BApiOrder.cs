namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiOrder(IBcApi api) : IBcApiOperation
{
    public B2BApiOrderGet Get() => new(api);
}