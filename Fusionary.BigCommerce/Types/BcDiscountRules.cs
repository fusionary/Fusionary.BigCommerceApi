namespace Fusionary.BigCommerce.Types;

public record BcDiscountRules
{
    [JsonPropertyName("type")]
    public BcDiscountTypes Type { get; set; }

    [JsonPropertyName("price_list_id")]
    public int? PriceListId { get; set; }

    [JsonPropertyName("method")]
    public BcDiscountRulesMethods? Method { get; set; }

    [JsonPropertyName("amount")]
    public decimal? Amount { get; set; }

    [JsonPropertyName("category_id")]
    public int? CategoryId { get; set; }

    [JsonPropertyName("product_id")]
    public int? ProductId { get; set; }
}