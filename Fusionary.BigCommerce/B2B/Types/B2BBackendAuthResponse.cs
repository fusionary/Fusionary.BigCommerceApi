namespace Fusionary.BigCommerce.B2B.Types;

public record B2BBackendAuthResponse
{
    [JsonPropertyName("token")]
    public string Token { get; init; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; init; } = null!;
}