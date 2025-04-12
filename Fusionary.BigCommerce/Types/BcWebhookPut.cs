namespace Fusionary.BigCommerce.Types;

public record BcWebhookPut : BcWebhookPost
{
    [JsonIgnore]
    public required BcId Id { get; set; }
}