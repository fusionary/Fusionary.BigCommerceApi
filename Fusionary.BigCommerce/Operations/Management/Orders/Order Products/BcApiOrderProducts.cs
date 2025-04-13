namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderProducts(IBcApi api) : IBcApiOperation
{
    public BcApiOrderProductsGet Get() => new(api);
}