namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcApiCustomerGroupGet : BcRequestBuilder,
    IBcApiOperation,
    IBcPageableFilter,
    IBcNameFilter,
    IBcDateCreatedFilter,
    IBcDateModifiedFilter
{
    public BcApiCustomerGroupGet(IBcApi api) : base(api)
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