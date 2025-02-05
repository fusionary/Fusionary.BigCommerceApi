namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcApiCustomerGroupUpdate : BcRequestBuilder, IBcApiOperation
{
    public BcApiCustomerGroupUpdate(IBcApi api) : base(api)
    {
    }
    
    public async Task<BcCustomerGroup> UpdateAsync(
        int id,
        BcCustomerGroupPost customerGroup,
        CancellationToken cancellationToken = default
    ) => await Api.PutDataAsync<BcCustomerGroup>(
        BcEndpoint.CustomersGroupsV2(id),
        customerGroup,
        Filter,
        Options,
        cancellationToken
    );
}