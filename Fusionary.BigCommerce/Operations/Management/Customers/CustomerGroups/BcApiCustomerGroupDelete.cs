namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcApiCustomerGroupDelete : BcRequestBuilder, IBcApiOperation
{
    public BcApiCustomerGroupDelete(IBcApi api) : base(api)
    {
    }
    
    public async Task<BcResult> DeleteAsync(
        int id,
        CancellationToken cancellationToken = default
    ) => await Api.DeleteAsync(
        BcEndpoint.CustomersGroupsV2(id),
        Filter,
        Options,
        cancellationToken
    );
}