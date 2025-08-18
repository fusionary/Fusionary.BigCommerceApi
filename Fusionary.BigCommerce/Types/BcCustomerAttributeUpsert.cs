namespace Fusionary.BigCommerce.Types;

public record BcCustomerAttributeUpsert
{
    [JsonPropertyName("id")]
    public BcId? Id { get; init; }
    
    [JsonPropertyName("attribute_id")]
    public BcId? AttributeId { get; init; }
    
    [JsonPropertyName("value")]
    public string? Value { get; init; }
    
    [JsonPropertyName("customer_id")]
    public BcId? CustomerId { get; init; }
}