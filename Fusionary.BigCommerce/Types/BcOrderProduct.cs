namespace Fusionary.BigCommerce.Types;

public record BcOrderProduct
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int OrderAddressId { get; set; }

    public string Name { get; set; } = null!;

    public string? NameCustomer { get; set; }

    public string? NameMerchant { get; set; }

    public string? Sku { get; set; }

    public string? Upc { get; set; }

    public string? Type { get; set; }

    public BcFloat BasePrice { get; set; }

    public BcFloat PriceExTax { get; set; }

    public BcFloat PriceIncTax { get; set; }

    public BcFloat PriceTax { get; set; }

    public BcFloat BaseTotal { get; set; }

    public BcFloat TotalExTax { get; set; }

    public BcFloat TotalIncTax { get; set; }

    public BcFloat TotalTax { get; set; }

    public BcFloat Weight { get; set; }

    public int Quantity { get; set; }

    public BcFloat BaseCostPrice { get; set; }

    public BcFloat CostPriceIncTax { get; set; }

    public BcFloat CostPriceExTax { get; set; }

    public BcFloat CostPriceTax { get; set; }

    public bool? IsRefunded { get; set; }

    public int? QuantityRefunded { get; set; }

    /// <summary>
    /// The amount refunded from this transaction; always returns 0
    /// </summary>
    public BcFloat? RefundAmount { get; set; }

    /// <summary>
    /// Numeric ID for the refund.
    /// </summary>
    public int? ReturnId { get; set; }

    public string? WrappingName { get; set; }

    public BcFloat? BaseWrappingCost { get; set; }

    public BcFloat? WrappingCostExTax { get; set; }

    public BcFloat? WrappingCostIncTax { get; set; }

    public BcFloat? WrappingCostTax { get; set; }

    public string? WrappingMessage { get; set; }

    public int? QuantityShipped { get; set; }

    /// <summary>
    /// Name of promotional event/delivery date.
    /// </summary>
    public string? EventName { get; set; }

    public BcDateTime? EventDate { get; set; }

    public BcFloat? FixedShippingCost { get; set; }

    public string? EbayItemId { get; set; }

    public string? EbayTransactionId { get; set; }

    /// <summary>
    /// Numeric ID of the option set applied to the product.
    /// </summary>
    public int? OptionSetId { get; set; }

    /// <summary>
    /// ID of a parent product.
    /// </summary>
    public int? ParentOrderProductId { get; set; }

    public bool? IsBundledProduct { get; set; }

    public string? BinPickingNumber { get; set; }

    public string? ExternalId { get; set; }

    public string? FulfillmentSource { get; set; }

    public string? Brand { get; set; }

    public List<BcOrderProductAppliedDiscount>? AppliedDiscounts { get; set; }

    public List<BcOrderProductOptions>? ProductOptions { get; set; }

    public int? GiftCertificateId { get; set; }

    public int? VariantId { get; set; }
}