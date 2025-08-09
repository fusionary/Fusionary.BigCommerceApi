using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiOrderGet(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<B2BOrder>> SendAsync(int bcOrderId, CancellationToken cancellationToken = default)
    => SendAsync<B2BOrder>(bcOrderId, cancellationToken);
    
    public Task<BcResultData<T>> SendAsync<T>(int bcOrderId, CancellationToken cancellationToken = default)
    => Api.GetDataAsync<T>(B2BEndpoints.OrdersV3(bcOrderId), Filter, Options, cancellationToken);
}