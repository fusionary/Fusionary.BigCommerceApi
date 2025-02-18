namespace Fusionary.BigCommerce.Types;

public record BcOrderConsignments()
{
    [JsonPropertyName("shipping")]
    public IEnumerable<BcOrderShipping>? Shipping { get; set; }
}