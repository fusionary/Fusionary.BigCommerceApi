namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcApiCustomerGroupUpdate : BcRequestBuilder, IBcApiOperation
{
    public BcApiCustomerGroupUpdate(IBcApi api) : base(api)
    { }

    public async Task<BcResultData<BcCustomerGroup>> SendAsync(
        int id,
        BcCustomerGroupPost customerGroup,
        CancellationToken cancellationToken = default
    ) => await SendAsync<BcCustomerGroup>(id, customerGroup, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        int id,
        BcCustomerGroupPost customerGroup,
        CancellationToken cancellationToken = default
    ) => await Api.PutDataAsync<T>(
        BcEndpoint.CustomersGroupsV2(id),
        customerGroup,
        Filter,
        Options,
        cancellationToken
    );
}