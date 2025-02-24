namespace Fusionary.BigCommerce.Operations;

public record BcOrderShipmentsItem
{
    [JsonPropertyName("order_product_id")]
    public int? OrderProductId { get; init; }

    [JsonPropertyName("quantity")]
    public int? Quantity { get; init; }
}