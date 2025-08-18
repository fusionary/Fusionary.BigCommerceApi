namespace Fusionary.BigCommerce.Operations;

public class BcApiCustomer(IBcApi api) : IBcApiOperation
{
    public BcApiCustomerGet Get() => new(api);
    
    public BcApiCustomerCreate Create() => new(api);
    
    public BcApiCustomerUpdate Update() => new(api);
    
    public BcApiCustomerAttributes Attributes() => new(api);
}