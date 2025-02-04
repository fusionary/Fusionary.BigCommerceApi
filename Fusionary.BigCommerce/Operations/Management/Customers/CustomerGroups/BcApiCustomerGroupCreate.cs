namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcApiCustomerGroupCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiCustomerGroupCreate(IBcApi api) : base(api)
    {
    }
    
    public async Task<BcResultData<object>> CreateAsync(
        BcCustomerGroupPost customerGroup,
        CancellationToken cancellationToken = default
    ) => await Api.PostDataAsync<object>(
        BcEndpoint.CustomersGroupsV2(),
        customerGroup,
        Filter,
        Options,
        cancellationToken
    );
}