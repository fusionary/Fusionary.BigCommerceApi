namespace Fusionary.BigCommerce.Types;

public record BcOrderTransaction
{
    [JsonPropertyName("id")]
    public BcId? Id { get; init; }
    
    [JsonPropertyName("order_id")]
    public BcId? OrderId { get; init; }
    
    [JsonPropertyName("date_created")]
    public BcDateTime DateCreated {get; init; }
    
    /// <summary>
    /// Store event that created the transaction.
    /// Allowed: purchase | authorization | capture | refund | void | pending | settled
    /// </summary>
    [JsonPropertyName("event")]
    public string? Event { get; init; }
    
    /// <summary>
    /// The payment method: credit_card - a credit card transaction; electronic_wallet - an online wallet; store_credit - a transaction using store credit; gift_certificate - a transaction using a gift certificate; custom - manual payment methods; token - payment token; nonce - temporary payment token; offsite - online payment off the site; offline - payment method that takes place offline.
    /// Allowed: credit_card | electronic_wallet | gift_certificate | store_credit | apple_pay_card | bigpay_token | apple_pay_token | token | custom | offsite | offline | nonce
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; init; }
    
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }
    
    /// <summary>
    /// The payment gateway, where applicable.
    /// Allowed: 2checkout | adyen | amazon | authorizenet | bankdeposit | braintree | cheque | cod | custom | firstdatagge4 | giftcertificate | hps | instore | klarna | migs | moneyorder | nmi | paypalexpress | paypalpaymentsprous | paypalpaymentsprouk | plugnpay | qbmsv2 | securenet | square | storecredit | stripe | testgateway | usaepay
    /// </summary>
    [JsonPropertyName("gateway")]
    public string? Gateway { get; init; }
    
    [JsonPropertyName("test")]
    public bool? IsTest { get; init; }
    
    [JsonPropertyName("status")]
    public string? Status { get; init; }
    
    [JsonPropertyName("fraud_review")]
    public bool? IsFraudReviewed { get; init; }
    
    [JsonPropertyName("payment_method_id")]
    public int? PaymentMethodId { get; init; }
    
    [JsonPropertyName("payment_instrument_token")]
    public string? PaymentInstrumentToken { get; init; }
    
    [JsonPropertyName("credit_card")]
    public BcOrderTransactionCreditCard? CreditCard { get; init; }
}

public record BcOrderTransactionCreditCard
{
    [JsonPropertyName("card_type")]
    public string? CardType { get; init; }
    
    [JsonPropertyName("card_iin")]
    public string? CardIIN { get; init; }
    
    [JsonPropertyName("card_last4")]
    public string? CardLast4 { get; init; }
    
    [JsonPropertyName("card_expiry_month")]
    public int? CardExpiryMonth { get; init; }
    
    [JsonPropertyName("card_expiry_year")]
    public int? CardExpiryYear { get; init; }
}