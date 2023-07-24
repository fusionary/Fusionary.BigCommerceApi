namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcProductType
{
    /// <summary>
    /// Exist in a physical form, have a weight, and are sold by merchants to ship to customers
    /// </summary>
    [JsonPropertyName("physical")]
    Physical,

    /// <summary>
    /// Non-physical products, including downloadable files (for example, computer software, ebooks, or music) and services
    /// (for example, haircuts, consulting, or lawn care).
    /// </summary>
    [JsonPropertyName("digital")]
    Digital
}
