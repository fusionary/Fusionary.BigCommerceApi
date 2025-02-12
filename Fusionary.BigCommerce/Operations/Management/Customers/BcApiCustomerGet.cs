namespace Fusionary.BigCommerce.Operations.Customers;

public class BcApiCustomerGet : BcRequestBuilder, IBcApiOperation
{
    public BcApiCustomerGet(IBcApi api) : base(api)
    {
    }
    
    public Task<BcResultData<BcCustomer>> SendAsync(
        int id,
        CancellationToken cancellationToken = default
    ) => SendAsync<BcCustomer>(id, cancellationToken);
    
    public async Task<BcResultData<T>> SendAsync<T>(
        int id,
        CancellationToken cancellationToken = default
    )
    {
        Filter.Add("id:in", id);
        
        return await Api.GetDataAsync<T>(
            BcEndpoint.CustomersV3(),
            Filter,
            Options,
            cancellationToken
        );
    }
}