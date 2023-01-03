namespace Fusionary.BigCommerce.Types;

public record BcCustomField
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("value")]
    public string Value { get; set; } = null!;
}