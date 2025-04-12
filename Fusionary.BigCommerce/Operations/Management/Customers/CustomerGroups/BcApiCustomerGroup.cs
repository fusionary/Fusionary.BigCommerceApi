namespace Fusionary.BigCommerce.Operations;

public class BcApiCustomerGroup(IBcApi api) : IBcApiOperation
{
    public BcApiCustomerGroupCreate Create() => new(api);

    public BcApiCustomerGroupDelete Delete() => new(api);

    public BcApiCustomerGroupGet Get() => new(api);

    public BcApiCustomerGroupGetAll GetAll() => new(api);

    public BcApiCustomerGroupUpdate Update() => new(api);
}