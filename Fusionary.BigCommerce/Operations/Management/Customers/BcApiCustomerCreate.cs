namespace Fusionary.BigCommerce.Operations;

public class BcApiCustomerCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcCustomer>> SendAsync(BcCustomer customer, CancellationToken cancellationToken = default)
        => SendAsync<BcCustomer>(customer, cancellationToken);

    public Task<BcResultData<T>> SendAsync<T>(object customer, CancellationToken cancellationToken = default)
        => Api.PostDataAsync<T>(BcEndpoint.CustomersV3(), customer, Filter, Options, cancellationToken);
}