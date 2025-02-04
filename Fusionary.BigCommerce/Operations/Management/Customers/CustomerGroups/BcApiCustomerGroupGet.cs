namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcApiCustomerGroupGet : BcRequestBuilder, IBcApiOperation
{
    public BcApiCustomerGroupGet(IBcApi api) : base(api)
    {
    }
    
    public async Task<BcResultData<object>> GetAsync(
        CancellationToken cancellationToken = default
    ) => await Api.GetDataAsync<object>(
        BcEndpoint.CustomersGroupsV2(),
        Filter,
        Options,
        cancellationToken
    );
}