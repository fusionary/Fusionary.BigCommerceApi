namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Category Tree {Name}")]
public record BcCategoryTreePathItem
{
    /// <summary>
    /// The unique numeric ID of the category.
    /// </summary>
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    /// <summary>
    /// The unique numeric ID of the category's parent. This field controls where the category sits in the tree of categories
    /// that organize the catalog.
    /// </summary>
    [JsonPropertyName("parent_id")]
    public int ParentId { get; init; }

    /// <summary>
    /// The name for the category.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("depth")]
    public int Depth { get; init; }

    /// <summary>
    /// The list of children of the category.
    /// </summary>
    [JsonPropertyName("children")]
    public required BcCategoryTreePathItem[] Children { get; init; }

    /// <summary>
    /// Flag to determine whether the product should be displayed to customers browsing the store. If `true`, the category will
    /// be displayed. If `false`, the category will be hidden from view.
    /// </summary>
    [JsonPropertyName("is_visible")]
    public bool IsVisible { get; init; }

    [JsonPropertyName("path")]
    public required int[] Path { get; init; }
}