namespace Fusionary.BigCommerce.B2B.Types;

public record B2BBackendAuthRequest
{
    [JsonPropertyName("storeHash")]
    public required string StoreHash { get; init; }

    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("password")]
    public required string Password { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }
}