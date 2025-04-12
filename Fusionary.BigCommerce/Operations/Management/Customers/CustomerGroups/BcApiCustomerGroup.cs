namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcApiCustomerGroup : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiCustomerGroup(IBcApi api)
    {
        _api = api;
    }

    public BcApiCustomerGroupCreate Create() => new(_api);

    public BcApiCustomerGroupDelete Delete() => new(_api);

    public BcApiCustomerGroupGet Get() => new(_api);

    public BcApiCustomerGroupGetAll GetAll() => new(_api);

    public BcApiCustomerGroupUpdate Update() => new(_api);
}