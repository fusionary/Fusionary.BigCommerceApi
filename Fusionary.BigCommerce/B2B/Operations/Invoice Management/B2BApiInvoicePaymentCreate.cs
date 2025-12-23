using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiInvoicePaymentCreate(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation
{
    public Task<BcResult<B2BInvoicePaymentCreateResponse, BcMetadataMessage>> SendAsync(B2BInvoicePaymentCreateRequest request, CancellationToken cancellationToken = default) =>
        Api.PostAsync<B2BInvoicePaymentCreateResponse, BcMetadataMessage>(B2BEndpoints.InvoiceManagementPaymentsOfflineV3(), request, Filter, Options, cancellationToken);
}
