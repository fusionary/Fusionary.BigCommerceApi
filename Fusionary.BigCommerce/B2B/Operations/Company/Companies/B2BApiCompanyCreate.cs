using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiCompanyCreate : BcRequestBuilder, IBcApiOperation
{
    public B2BApiCompanyCreate(IBcApi api) : base(api)
    {
        Options.RequestOverrides.IsB2B = true;
    }
    
    public Task<BcResultData<B2BCompany>> SendAsync(B2BCompany company, CancellationToken cancellationToken = default)
    => SendAsync<B2BCompany>(company, cancellationToken);

    public Task<BcResultData<T>> SendAsync<T>(object company, CancellationToken cancellationToken = default)
    => Api.PostDataAsync<T>(B2BEndpoints.Companies(), company, Filter, Options, cancellationToken);

}