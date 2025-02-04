namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcApiCustomerGroup : IBcApiOperation
{
    private readonly IBcApi _api;
    
    public BcApiCustomerGroup(IBcApi api)
    {
        _api = api;
    }

    public BcApiPriceListsGet Get() => new(_api);

}