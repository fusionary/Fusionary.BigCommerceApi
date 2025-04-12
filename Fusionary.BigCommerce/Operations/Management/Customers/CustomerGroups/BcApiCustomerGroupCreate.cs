namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcApiCustomerGroupCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiCustomerGroupCreate(IBcApi api) : base(api)
    { }

    public async Task<BcResultData<BcCustomerGroup>> SendAsync(
        BcCustomerGroupPost customerGroup,
        CancellationToken cancellationToken = default
    ) => await SendAsync<BcCustomerGroup>(customerGroup, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        BcCustomerGroupPost customerGroup,
        CancellationToken cancellationToken = default
    ) => await Api.PostDataAsync<T>(
        BcEndpoint.CustomersGroupsV2(),
        customerGroup,
        Filter,
        Options,
        cancellationToken
    );
}