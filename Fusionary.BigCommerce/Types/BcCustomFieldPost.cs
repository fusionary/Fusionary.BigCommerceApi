namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{Name}:{Value}")]
public record BcCustomFieldPost
{
    /// <summary>
    /// The unique numeric ID of the custom field; increments sequentially.
    /// Required to update existing custom field in /PUT request. Read-Only
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the field, shown on the storefront, orders, etc. Required for /POST
    /// </summary>
    /// <remarks>
    /// Max length: 250
    /// </remarks>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The name of the field, shown on the storefront, orders, etc. Required for /POST
    /// </summary>
    /// <remarks>
    /// Max length: 250
    /// </remarks>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}
