namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcAvailability
{
    /// <summary>
    /// The product is available for purchase
    /// </summary>
    [JsonPropertyName("available")]
    Available,

    /// <summary>
    /// The product is listed on the storefront, but cannot be purchased
    /// </summary>
    [JsonPropertyName("disabled")]
    Disabled,

    /// <summary>
    /// The product is listed for pre-orders.
    /// </summary>
    [JsonPropertyName("preorder")]
    Preorder
}