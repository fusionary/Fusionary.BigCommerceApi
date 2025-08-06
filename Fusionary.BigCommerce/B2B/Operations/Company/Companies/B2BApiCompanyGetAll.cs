using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiCompanyGetAll : BcRequestBuilder, IBcApiOperation, IBcPageableFilter, IBcIncludeFieldsFilter
{
    public B2BApiCompanyGetAll(IBcApi api) : base(api)
    {
        Options.RequestOverrides.IsB2B = true;
    }
    
    public Task<BcResultPaged<B2BCompany>> SendAsync(CancellationToken cancellationToken = default)
    => SendAsync<B2BCompany>(cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(CancellationToken cancellationToken = default)
    {
        Options.RequestOverrides.IsB2B = true;
        return await Api.GetPagedAsync<T>(B2BEndpoints.Companies(), Filter, Options, cancellationToken);
    }
}