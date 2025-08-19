using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiInvoiceGet(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation
{
    public Task<BcResult<List<B2BInvoice>,B2BMetadataPagination>> SendAsync(CancellationToken cancellationToken = default) =>
        Api.GetAsync<List<B2BInvoice>,B2BMetadataPagination>(B2BEndpoints.InvoiceManagementInvoicesV3(), Filter, Options, cancellationToken);

    public Task<BcResult<List<B2BInvoice>,B2BMetadataPagination>> SendAsync(BcId invoiceId, CancellationToken cancellationToken = default) =>
        Api.GetAsync<List<B2BInvoice>,B2BMetadataPagination>(B2BEndpoints.InvoiceManagementInvoicesV3(invoiceId), Filter, Options, cancellationToken);

}