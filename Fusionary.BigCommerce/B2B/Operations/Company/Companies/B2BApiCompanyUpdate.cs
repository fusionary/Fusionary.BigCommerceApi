using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiCompanyUpdate(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<B2BCompany>> SendAsync(int id, B2BCompany company, CancellationToken cancellationToken = default)
        => SendAsync<B2BCompany>(id, company, cancellationToken);

    public Task<BcResultData<T>> SendAsync<T>(int id, object company, CancellationToken cancellationToken = default)
        => Api.PutDataAsync<T>(B2BEndpoints.Companies(id), company, Filter, Options, cancellationToken);

}