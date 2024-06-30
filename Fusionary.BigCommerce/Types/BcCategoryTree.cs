namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Category Tree {Id}:{Name}")]
public record BcCategoryTree : BcCategoryTreeUpsert
{
    [JsonPropertyName("id")]
    public new int Id { get; set; }
}