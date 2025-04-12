namespace Fusionary.BigCommerce.Types;

public record BcStoreCreditAmounts
{
    [JsonPropertyName("amount")]
    public BcFloat Amount { get; set; }
}