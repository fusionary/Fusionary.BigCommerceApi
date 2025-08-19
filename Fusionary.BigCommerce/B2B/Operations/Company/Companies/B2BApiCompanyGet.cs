using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiCompanyGet(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation, IBcIncludeFieldsFilter
{
    public Task<BcResult<B2BCompany, BcMetadataMessage>> SendAsync(BcId companyId, CancellationToken cancellationToken = default)
        => SendAsync<B2BCompany>(companyId,cancellationToken);

    public async Task<BcResult<T, BcMetadataMessage>> SendAsync<T>(BcId companyId, CancellationToken cancellationToken = default)
    {
        return await Api.GetAsync<T, BcMetadataMessage>(B2BEndpoints.Companies(companyId), Filter, Options, cancellationToken);
    }
}