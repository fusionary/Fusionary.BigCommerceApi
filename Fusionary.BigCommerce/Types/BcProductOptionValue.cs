namespace Fusionary.BigCommerce.Types;

public record BcProductOptionValue : IExtensionData
{
    /// <summary>
    /// The unique numerical ID of the option value.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// The unique numerical ID of the option.
    /// </summary>
    [JsonPropertyName("option_id")]
    public int OptionId { get; set; }

    /// <summary>
    /// The text display identifying the value on the storefront.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    /// <summary>
    /// The order in which the value will be displayed on the product page.
    /// </summary>
    [JsonPropertyName("sort_order")]
    public required int SortOrder { get; set; }

    /// <summary>
    /// The flag for preselecting a value as the default on the storefront.
    /// </summary>
    [JsonPropertyName("is_default")]
    public bool IsDefault { get; set; }

    /// <summary>
    /// Extra data describing the value, based on the type of option or modifier with which the value is associated.
    /// </summary>
    [JsonPropertyName("value_data")]
    public Dictionary<string, object>? ValueData { get; set; }

    

    /// <inheritdoc />
    public IDictionary<string, JsonElement>? ExtensionData { get; init; }
}


