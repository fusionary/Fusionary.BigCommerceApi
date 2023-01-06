namespace Fusionary.BigCommerce.Types;

public record BcCustomField
{
    /// <summary>
    /// The unique numeric ID of the custom field; increments sequentially.
    /// Required to update existing custom field in /PUT request. Read-Only
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// The name of the field, shown on the storefront, orders, etc. Required for /POST
    /// </summary>
    /// <remarks>
    /// Max length: 250
    /// </remarks>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// The name of the field, shown on the storefront, orders, etc. Required for /POST
    /// </summary>
    /// <remarks>
    /// Max length: 250
    /// </remarks>
    [JsonPropertyName("value")]
    public string Value { get; set; } = null!;
}