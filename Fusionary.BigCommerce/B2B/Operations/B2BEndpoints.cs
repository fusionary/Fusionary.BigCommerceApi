using System.Diagnostics.CodeAnalysis;

namespace Fusionary.BigCommerce.B2B.Operations;

[SuppressMessage("Minor Code Smell", "S3400:Methods should not return constants")]
public static class B2BEndpoints
{
    public static string AuthBackend() => "io/auth/backend";

    public static string AuthBackendTokens() => "io/auth/backend/tokens";

    public static string AuthStorefront() => "io/auth/storefront";

    public static string ChannelsV3() => "v3/io/channels";

    public static string InvoiceManagementInvoicesV3() => $"{InvoiceManagementV3()}/invoices";

    public static string InvoiceManagementInvoicesV3(BcId invoiceId) => $"{InvoiceManagementInvoicesV3()}/{invoiceId}";

    public static string InvoiceManagementPaymentsV3() => $"{InvoiceManagementV3()}/payments";

    public static string InvoiceManagementPaymentsV3(BcId paymentId) => $"{InvoiceManagementPaymentsV3()}/{paymentId}";

    public static string InvoiceManagementReceiptsV3() => $"{InvoiceManagementV3()}/receipts";

    public static string InvoiceManagementReceiptsV3(BcId receiptId) => $"{InvoiceManagementReceiptsV3()}/{receiptId}";

    public static string InvoiceManagementV3() => "v3/io/ip";

    public static string OrderExtraFieldsV3() => $"{OrdersV3()}/extra-fields";

    public static string OrderProductsV3(BcId orderId) => $"{OrdersV3(orderId)}/products";
    
    public static string OrderCustomersV3(BcId customerId) => $"v3/io/customers/{customerId}/orders/b2b";

    public static string OrdersV3() => "v3/io/orders";

    public static string OrdersV3(BcId orderId) => $"{OrdersV3()}/{orderId}";
    
    public static string PaymentsV3() => "v3/io/payments";

    public static string Companies() => "v3/io/companies";

    public static string Companies(int id) => $"{Companies()}/{id}";

    public static string CreditStatus(int id) => $"{Companies(id)}/credit";
    
    public static string Users() => $"v3/io/users";

}
