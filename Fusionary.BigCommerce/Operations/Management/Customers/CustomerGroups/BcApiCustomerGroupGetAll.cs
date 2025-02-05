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

    public async Task<BcResultPaged<BcCustomerGroup>> GetAllAsync(
        CancellationToken cancellationToken = default
    ) => await Api.GetPagedAsync<BcCustomerGroup>(
        BcEndpoint.CustomersGroupsV2(),
        Filter,
        Options,
        cancellationToken
    );
}