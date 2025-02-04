namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcApiCustomerGroupUpdate : BcRequestBuilder, IBcApiOperation
{
    public BcApiCustomerGroupUpdate(IBcApi api) : base(api)
    {
    }
    
    public async Task<BcResultData<object>> UpdateAsync(
        int id,
        BcCustomerGroupPost customerGroup,
        CancellationToken cancellationToken = default
    ) => await Api.PutDataAsync<object>(
        BcEndpoint.CustomersGroupsV2(id),
        customerGroup,
        Filter,
        Options,
        cancellationToken
    );
}