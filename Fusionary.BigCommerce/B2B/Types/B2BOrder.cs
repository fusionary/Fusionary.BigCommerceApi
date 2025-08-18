namespace Fusionary.BigCommerce.B2B.Types;

public class B2BOrder
{
    [JsonPropertyName("id")]
    public int? B2BOrderId { get; set; }
    
    [JsonPropertyName("bcOrderId")]
    public int? BCOrderId { get; set; }
    
    [JsonPropertyName("totalIncTax")]
    public decimal? TotalIncludingTax { get; set; }
    
    [JsonPropertyName("poNumber")]
    public string? PONumber { get; set; }
    
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    
    [JsonPropertyName("customStatus")]
    public string? CustomStatus { get; set; }
    
    [JsonPropertyName("cartId")]
    public int? CartId { get; set; }
    
    [JsonPropertyName("items")]
    public int? ItemCount { get; set; }
    
    [JsonPropertyName("usdIncTax")]
    public decimal? TotalUSDIncludingTax { get; set; }
    
    [JsonPropertyName("companyId")]
    public int? CompanyId { get; set; }
    
    [JsonPropertyName("currencyCode")]
    public string? CurrencyCode { get; set; }
    
    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }
    
    [JsonPropertyName("isArchived")]
    public bool? IsArchived { get; set; }
    
    [JsonPropertyName("channelId")]
    public int? ChannelId { get; set; }
    
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }
    
    [JsonPropertyName("isInvoiceOrder")]
    public int? IsInvoiceOrder { get; set; }
    
    [JsonPropertyName("invoiceId")]
    public int? InvoiceId { get; set; }
    
    [JsonPropertyName("invoiceNumber")]
    public int? InvoiceNumber { get; set; }
    
    [JsonPropertyName("invoiceStatus")]
    public int? InvoiceStatus { get; set; }
    
    [JsonPropertyName("createdAt")]
    public int? CreatedAtTimestamp { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public int? UpdatedAtTimestamp { get; set; }
    
    [JsonPropertyName("extraFields")]
    public List<B2BOrderExtraField> ExtraFields { get; set; } = new List<B2BOrderExtraField>();
    
    [JsonPropertyName("extraInfo")]
    public List<B2BOrderExtraInfo> ExtraInfo { get; set; } = new List<B2BOrderExtraInfo>();
}