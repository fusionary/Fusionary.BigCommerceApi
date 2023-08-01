namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Category {Id}:{Name}")]
public record BcCategory : BcCategoryPost
{
    /// <summary>
    /// Unique ID of the Category. Increments sequentially
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
}