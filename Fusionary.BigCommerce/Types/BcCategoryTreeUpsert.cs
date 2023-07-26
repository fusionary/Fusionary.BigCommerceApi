namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Category Tree {Name}")]
public record BcCategoryTreeUpsert
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("channels")]
    public required int[] Channels { get; set; }
}