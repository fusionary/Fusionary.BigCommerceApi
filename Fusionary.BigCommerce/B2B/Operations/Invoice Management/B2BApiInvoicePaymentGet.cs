using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiInvoicePaymentGet(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation, IBcPageableFilter, IBcWithParameterFilter
{
    public Task<BcResultPaged<B2BInvoicePayment>> SendAsync(CancellationToken cancellationToken = default)
        => Api.GetPagedAsync<B2BInvoicePayment>(B2BEndpoints.InvoiceManagementPaymentsV3(), Filter, Options, cancellationToken);

    public Task<BcResult<B2BInvoicePayment, BcMetadataMessage>> SendAsync(BcId paymentId, CancellationToken cancellationToken = default)
        => Api.GetAsync<B2BInvoicePayment, BcMetadataMessage>(B2BEndpoints.InvoiceManagementPaymentsV3(paymentId), Filter, Options, cancellationToken);
}
