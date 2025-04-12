namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Category {Id}:{Name}")]
public record BcCategory : BcCategoryPost
{
    /// <summary>
    /// Unique ID of the Category. Increments sequentially
    /// </summary>
    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int Id { get; set; }
}