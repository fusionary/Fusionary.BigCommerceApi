namespace Fusionary.BigCommerce.Types;

public static class BcOrderStatus
{
    /// <summary>
    /// An incomplete order happens when a shopper reached the payment page, but did not complete the transaction.
    /// </summary>
    public const int Incomplete = 0;

    /// <summary>
    /// Customer started the checkout process, but did not complete it.
    /// </summary>
    public const int Pending = 1;

    /// <summary>
    /// Order has been shipped, but receipt has not been confirmed; seller has used the Ship Items action.
    /// </summary>
    public const int Shipped = 2;

    /// <summary>
    /// Only some items in the order have been shipped, due to some products being pre-order only or other reasons.
    /// </summary>
    public const int PartiallyShipped = 3;

    /// <summary>
    /// Seller has used the Refund action.
    /// </summary>
    public const int Refunded = 4;

    /// <summary>
    /// Seller has cancelled an order, due to a stock inconsistency or other reasons.
    /// </summary>
    public const int Cancelled = 5;

    /// <summary>
    /// Seller has marked the order as declined for lack of manual payment, or other reasons.
    /// </summary>
    public const int Declined = 6;

    /// <summary>
    /// Customer has completed checkout process, but payment has yet to be confirmed.
    /// </summary>
    public const int AwaitingPayment = 7;

    /// <summary>
    /// Order has been pulled, and is awaiting customer pickup from a seller-specified location.
    /// </summary>
    public const int AwaitingPickup = 8;

    /// <summary>
    /// Order has been pulled and packaged, and is awaiting collection from a shipping provider.
    /// </summary>
    public const int AwaitingShipment = 9;

    /// <summary>
    /// Client has paid for their digital product and their file(s) are available for download.
    /// </summary>
    public const int Completed = 10;

    /// <summary>
    /// Customer has completed the checkout process and payment has been confirmed.
    /// </summary>
    public const int AwaitingFulfillment = 11;

    /// <summary>
    /// Order is on hold while some aspect needs to be manually confirmed.
    /// </summary>
    public const int ManualVerificationRequired = 12;

    /// <summary>
    /// Customer has initiated a dispute resolution process for the PayPal transaction that paid for the order.
    /// </summary>
    public const int Disputed = 13;

    /// <summary>
    /// Seller has partially refunded the order.
    /// </summary>
    public const int PartiallyRefunded = 14;
}