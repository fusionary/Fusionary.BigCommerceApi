namespace Fusionary.BigCommerce.Operations.Customers;

public class BcApiCustomer : IBcApiOperation
{
    private readonly IBcApi _api;
    
    public BcApiCustomer(IBcApi api)
    {
        _api = api;
    }
}