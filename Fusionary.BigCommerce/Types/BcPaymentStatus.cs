namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum BcPaymentStatus
{
    [JsonPropertyName("")]
    Unknown = 0,

    [JsonPropertyName("authorized")]
    Authorized,

    [JsonPropertyName("captured")]
    Captured,

    [JsonPropertyName("refunded")]
    Refunded,

    [JsonPropertyName("partially refunded")]
    PartiallyRefunded,

    [JsonPropertyName("void")]
    Void
}