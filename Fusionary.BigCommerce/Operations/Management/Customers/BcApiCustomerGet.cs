namespace Fusionary.BigCommerce.Operations;

public class BcApiCustomerGet(IBcApi api) : BcRequestBuilder(api), IBcApiOperation, IBcPageableFilter, IBcProductIncludeFilter
{
    public Task<BcResultPaged<BcCustomer>> SendAsync(
        CancellationToken cancellationToken = default
    ) => SendAsync<BcCustomer>(cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(
        CancellationToken cancellationToken = default
    )
    {
        return await Api.GetPagedAsync<T>(
            BcEndpoint.CustomersV3(),
            Filter,
            Options,
            cancellationToken
        );
    }
    
    public Task<BcResultPaged<BcCustomer>> SendAsync(
        int id,
        CancellationToken cancellationToken = default
    ) => SendAsync<BcCustomer>(id, cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(
        int id,
        CancellationToken cancellationToken = default
    )
    {
        Filter.Add("id:in", id);

        return await Api.GetPagedAsync<T>(
            BcEndpoint.CustomersV3(),
            Filter,
            Options,
            cancellationToken
        );
    }
}