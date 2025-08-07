namespace Fusionary.BigCommerce.Types;

public record BcCustomerAttribute
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("attribute_id")]
    public int AttributeId { get; set; }

    [JsonPropertyName("attribute_value")]
    public string? AttributeValue { get; set; }

    [JsonPropertyName("customer_id")]
    public int? CustomerId { get; set; }

    [JsonPropertyName("date_created")]
    public BcDateTime? DateCreated { get; set; }

    [JsonPropertyName("date_modified")]
    public BcDateTime? DateModified { get; set; }
}