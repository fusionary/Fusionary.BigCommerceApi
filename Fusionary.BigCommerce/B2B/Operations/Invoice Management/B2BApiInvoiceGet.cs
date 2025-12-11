using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiInvoiceGet(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultPaged<B2BInvoice>> SendAsync(CancellationToken cancellationToken = default) =>
        Api.GetPagedAsync<B2BInvoice>(B2BEndpoints.InvoiceManagementInvoicesV3(), Filter, Options, cancellationToken);

    public Task<BcResult<B2BInvoice, BcMetadataMessage>> SendAsync(BcId invoiceId, CancellationToken cancellationToken = default) =>
        Api.GetAsync<B2BInvoice, BcMetadataMessage>(B2BEndpoints.InvoiceManagementInvoicesV3(invoiceId), Filter, Options, cancellationToken);

}