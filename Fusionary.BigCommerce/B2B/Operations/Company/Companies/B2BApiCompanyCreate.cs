using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiCompanyCreate(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<B2BCompanyCreate>> SendAsync(B2BCompanyCreate company, CancellationToken cancellationToken = default)
    => SendAsync<B2BCompanyCreate>(company, cancellationToken);

    public Task<BcResultData<T>> SendAsync<T>(object company, CancellationToken cancellationToken = default)
    => Api.PostDataAsync<T>(B2BEndpoints.Companies(), company, Filter, Options, cancellationToken);

}