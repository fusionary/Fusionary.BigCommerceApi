namespace Fusionary.BigCommerce.Operations;

public record BcOrderShipmentsPost
{
    [JsonPropertyName("shipping_provider")]
    public string? ShippingProvider { get; init; }

    [JsonPropertyName("tracking_number")]
    public string? TrackingNumber { get; init; }

    [JsonPropertyName("order_address_id")]
    public int? OrderAddressId { get; init; }

    [JsonPropertyName("items")]
    public List<BcOrderShipmentsItem>? Items { get; init; }
}