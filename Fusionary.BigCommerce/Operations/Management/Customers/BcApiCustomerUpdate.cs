namespace Fusionary.BigCommerce.Operations;

public class BcApiCustomerUpdate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<List<BcCustomer>>> SendAsync(List<BcCustomer> customers, CancellationToken cancellationToken = default)
        => SendAsync<List<BcCustomer>>(customers, cancellationToken);

    public Task<BcResultData<T>> SendAsync<T>(object customer, CancellationToken cancellationToken = default)
        => Api.PutDataAsync<T>(BcEndpoint.CustomersV3(), customer, Filter, Options, cancellationToken);
}