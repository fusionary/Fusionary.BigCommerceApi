namespace Fusionary.BigCommerce.Operations;

public class BcApiStorefront(IBcApi api) : IBcApiOperation
{
    public BcStorefrontTokenGet GetToken() => new(api);
}