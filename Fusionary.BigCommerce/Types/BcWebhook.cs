namespace Fusionary.BigCommerce.Types;

public record BcWebhook : BcWebhookPost
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("client_id")]
    public string ClientId { get; set; } = null!;

    [JsonPropertyName("store_hash")]
    public string StoreHash { get; set; } = null!;

    [JsonPropertyName("created_at")]
    public BcDateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public BcDateTime UpdatedAt { get; set; }
}