namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Category Tree {Name}")]
public record BcCategoryTreePathItem
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("parent_id")]
    public int ParentId { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("depth")]
    public int Depth { get; init; }

    [JsonPropertyName("children")]
    public required BcCategoryTreePathItem[] Children { get; init; }

    [JsonPropertyName("is_visible")]
    public bool IsVisible { get; init; }

    [JsonPropertyName("path")]
    public required int[] Path { get; init; }
}
