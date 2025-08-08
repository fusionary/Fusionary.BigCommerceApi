using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiCompanyGetAll(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation, IBcPageableFilter, IBcIncludeFieldsFilter, IBcWithParameterFilter
{
    public Task<BcResultPaged<B2BCompany>> SendAsync(CancellationToken cancellationToken = default)
    => SendAsync<B2BCompany>(cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(CancellationToken cancellationToken = default)
    {
        return await Api.GetPagedAsync<T>(B2BEndpoints.Companies(), Filter, Options, cancellationToken);
    }
}