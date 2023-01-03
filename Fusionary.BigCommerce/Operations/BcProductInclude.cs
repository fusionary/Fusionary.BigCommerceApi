namespace Fusionary.BigCommerce.Operations;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcProductInclude
{
    [JsonPropertyName("variants")]
    Variants,
    [JsonPropertyName("images")]
    Images,
    [JsonPropertyName("custom_fields")]
    CustomFields,
    [JsonPropertyName("bulk_pricing_rules")]
    BulkPricingRules,
    [JsonPropertyName("primary_image")]
    PrimaryImage,
    [JsonPropertyName("modifiers")]
    Modifiers,
    [JsonPropertyName("options")]
    Options,
    [JsonPropertyName("videos")]
    Videos
}