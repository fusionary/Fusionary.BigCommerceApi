namespace Fusionary.BigCommerce.Types;

public record BcOrderShipments{
    
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("order_id")]
    public int OrderId { get; init; }

    [JsonPropertyName("order_address_id")]
    public int order_address_id { get; init; }

    [JsonPropertyName("tracking_number")]
    public string TrackingNumber { get; init; } = string.Empty;

    [JsonPropertyName("carrier")]
    public string Carrier { get; init; } = string.Empty;

    [JsonPropertyName("shipping_method")]
    public string? ShippingMethod { get; init; }

    [JsonPropertyName("shipping_provider")]
    public string? ShippingProvider { get; init; } = string.Empty;

    [JsonPropertyName("shipped_date")]
    public DateTime ShippedDate { get; init; }

    [JsonPropertyName("items")]
    public List<BcOrderShipmentsItem> Items { get; init; } = [];

    [JsonPropertyName("generated_tracking_url")]
    public string? GeneratedTrackingUrl { get; init; }

}
