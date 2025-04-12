namespace Fusionary.BigCommerce.Operations;

public class BcApiCustomerGroupDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
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