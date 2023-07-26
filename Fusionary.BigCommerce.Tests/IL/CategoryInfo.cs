using System.Text.Json.Serialization;

namespace Fusionary.BigCommerce.Tests;

public record CategoryInfo
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("code")]
    public required string Code { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }
}