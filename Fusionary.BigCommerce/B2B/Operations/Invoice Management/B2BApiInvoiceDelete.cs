namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiInvoiceDelete(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation
{
    public Task<BcResult> SendAsync(BcId invoiceId, CancellationToken cancellationToken = default) =>
        Api.DeleteAsync(B2BEndpoints.InvoiceManagementInvoicesV3(invoiceId), Filter, Options, cancellationToken);
}
