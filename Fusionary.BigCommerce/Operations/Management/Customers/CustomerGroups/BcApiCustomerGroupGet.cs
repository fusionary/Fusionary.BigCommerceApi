namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcApiCustomerGroupGet : BcRequestBuilder, IBcApiOperation
{
    public BcApiCustomerGroupGet(IBcApi api) : base(api)
    {
    }
    
    public async Task<BcCustomerGroup> GetAsync(
        int id,
        CancellationToken cancellationToken = default
    ) => await Api.GetDataAsync<BcCustomerGroup>(
        BcEndpoint.CustomersGroupsV2(id),
        Filter,
        Options,
        cancellationToken
    );
}