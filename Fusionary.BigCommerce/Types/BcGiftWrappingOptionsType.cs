namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcGiftWrappingOptionsType
{
    /// <summary>
    /// allow any gift-wrapping options in the store
    /// </summary>
    [JsonPropertyName("any")]
    Any,

    /// <summary>
    /// disallow gift-wrapping on the product
    /// </summary>
    [JsonPropertyName("none")]
    None,

    /// <summary>
    /// provide a list of IDs in the gift_wrapping_options_list field.
    /// </summary>
    [JsonPropertyName("list")]
    List
}