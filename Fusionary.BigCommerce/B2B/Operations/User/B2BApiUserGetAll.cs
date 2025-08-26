using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiUserGetAll(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultPaged<B2BUser>> SendAsync(CancellationToken cancellationToken = default) => 
        SendAsync<B2BUser>(cancellationToken);
    
    public Task<BcResultPaged<T>> SendAsync<T>(CancellationToken cancellationToken = default) =>
        Api.GetPagedAsync<T>(B2BEndpoints.Users(), Filter, Options, cancellationToken);
}