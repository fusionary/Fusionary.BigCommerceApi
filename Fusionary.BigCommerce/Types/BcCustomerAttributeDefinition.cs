namespace Fusionary.BigCommerce.Types;

public record BcCustomerAttributeDefinition
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; } 
    
    [JsonPropertyName("type")]
    public string? Type { get; set; } 
    
    [JsonPropertyName("date_modified")]
    public BcDateTime? DateModified { get; set; } 
    
    [JsonPropertyName("date_created")]
    public BcDateTime? DateCreated { get; set; }
}