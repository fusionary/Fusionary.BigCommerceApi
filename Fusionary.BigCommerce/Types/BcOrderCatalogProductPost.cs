using Fusionary.BigCommerce.Operations;

namespace Fusionary.BigCommerce.Types;

public record BcOrderCatalogProductPost
{
    [JsonPropertyName("product_id")]
    public int ProductId { get; set; }

    [JsonPropertyName("product_options")]
    public List<BcProductOptions>? ProductOptions { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("name_customer")]
    public string? NameCustomer { get; set; }
    
    [JsonPropertyName("name_merchant")]
    public string? NameMerchant { get; set; }
    
    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }
    
    [JsonPropertyName("price_inc_tax")]
    public BcFloat? PriceIncTax { get; set; }
    
    [JsonPropertyName("price_ex_tax")]
    public BcFloat? PriceExTax { get; set; }
    
    [JsonPropertyName("upc")]
    public string? Upc { get; set; }
    
    [JsonPropertyName("variant_id")]
    public int? VariantId { get; set; }
    
    [JsonPropertyName("wrapping_id")]
    public int? WrappingId { get; set; }
    
    [JsonPropertyName("wrapping_name")]
    public string? WrappingName { get; set; }
    
    [JsonPropertyName("wrapping_message")]
    public string? WrappingMessage { get; set; }
    
    [JsonPropertyName("wrapping_cost_inc_tax")]
    public BcFloat? WrappingCostIncTax { get; set; }
    
    [JsonPropertyName("wrapping_cost_ex_tax")]
    public BcFloat? WrappingCostExTax { get; set; }
}