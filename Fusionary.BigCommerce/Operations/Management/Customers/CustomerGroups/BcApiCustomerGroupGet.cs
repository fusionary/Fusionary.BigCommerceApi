namespace Fusionary.BigCommerce.Operations;

public class BcApiCustomerGroupGet(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcCustomerGroup>> SendAsync(
        int id,
        CancellationToken cancellationToken = default
    ) => SendAsync<BcCustomerGroup>(id, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        int id,
        CancellationToken cancellationToken = default
    ) => await Api.GetDataAsync<T>(
        BcEndpoint.CustomersGroupsV2(id),
        Filter,
        Options,
        cancellationToken
    );
}