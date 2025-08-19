using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiInvoiceCreate(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation
{
    public Task<BcResult<B2BInvoice,BcMetadataMessage>> SendAsync(B2BInvoice invoice, CancellationToken cancellationToken = default) =>
        Api.PostAsync<B2BInvoice, BcMetadataMessage>(B2BEndpoints.InvoiceManagementInvoicesV3(), invoice, Filter, Options, cancellationToken);
}