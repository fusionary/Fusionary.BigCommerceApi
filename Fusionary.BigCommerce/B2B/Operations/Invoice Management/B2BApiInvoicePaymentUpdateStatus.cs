using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiInvoicePaymentUpdateStatus(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultDataWithMessage<B2BInvoicePayment>> SendAsync(BcId paymentId, B2BInvoicePaymentStatusUpdate statusUpdate, CancellationToken cancellationToken = default)
        => Api.PutDataWithMessageAsync<B2BInvoicePayment>(B2BEndpoints.InvoiceManagementPaymentsV3(paymentId) + "/processing-status", statusUpdate, Filter, Options, cancellationToken);
}
