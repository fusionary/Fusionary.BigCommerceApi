namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcApiCustomerGroupCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiCustomerGroupCreate(IBcApi api) : base(api)
    {
    }
    
    public async Task<BcCustomerGroup> CreateAsync(
        BcCustomerGroupPost customerGroup,
        CancellationToken cancellationToken = default
    ) => await Api.PostDataAsync<BcCustomerGroup>(
        BcEndpoint.CustomersGroupsV2(),
        customerGroup,
        Filter,
        Options,
        cancellationToken
    );
}