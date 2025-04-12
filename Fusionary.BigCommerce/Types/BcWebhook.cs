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
    public BcDate CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public BcDate UpdatedAt { get; set; }
}