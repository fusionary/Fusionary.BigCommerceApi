namespace Fusionary.BigCommerce.Types;

public record BcPriceListRecord : BcPriceListRecordPut
{
    [JsonPropertyName("calculated_price")]
    public BcFloat? CalculatedPrice { get; set; }

    [JsonPropertyName("date_created")]
    public BcDateTime DateCreated { get; set; }

    [JsonPropertyName("date_modified")]
    public BcDateTime DateModified { get; set; }
    
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    [JsonPropertyName("product_id")]
    public int ProductId { get; set; }
}