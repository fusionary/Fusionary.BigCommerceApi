namespace Fusionary.BigCommerce.Operations;

public class BcApiCustomerCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<List<BcCustomer>>> SendAsync(List<BcCustomerPost> customers, CancellationToken cancellationToken = default)
        => SendAsync<List<BcCustomer>>(customers, cancellationToken);

    public Task<BcResultData<T>> SendAsync<T>(object customers, CancellationToken cancellationToken = default)
        => Api.PostDataAsync<T>(BcEndpoint.CustomersV3(), customers, Filter, Options, cancellationToken);
}