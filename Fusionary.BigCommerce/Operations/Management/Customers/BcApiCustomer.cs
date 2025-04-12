namespace Fusionary.BigCommerce.Operations;

public class BcApiCustomer(IBcApi api) : IBcApiOperation
{
    public BcApiCustomerGet Get() => new(api);
}