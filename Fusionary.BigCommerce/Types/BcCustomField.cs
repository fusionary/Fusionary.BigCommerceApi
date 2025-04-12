namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{Name}:{Value}")]
public record BcCustomField : BcCustomFieldPost
{
    /// <summary>
    /// The unique numeric ID of the custom field; increments sequentially.
    /// Required to update existing custom field in /PUT request. Read-Only
    /// </summary>
    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public new int Id { get; set; }
}