namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcApiCustomerGroupGetAll : BcRequestBuilder,
    IBcApiOperation,
    IBcPageableFilter,
    IBcNameFilter,
    IBcDateCreatedFilter,
    IBcDateModifiedFilter
{
    public BcApiCustomerGroupGetAll(IBcApi api) : base(api)
    {
    }
    
    public async Task<BcResultPaged<BcCustomerGroup>> SendAsync(
        CancellationToken cancellationToken = default
    ) => await SendAsync<BcCustomerGroup>(cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(
        CancellationToken cancellationToken = default
    ) => await Api.GetPagedAsync<T>(
        BcEndpoint.CustomersGroupsV2(),
        Filter,
        Options,
        cancellationToken
    );
}