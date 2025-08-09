namespace Fusionary.BigCommerce.B2B.Types;

public class B2BOrderExtraField
{
    [JsonPropertyName("fieldName")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("fieldValue")]
    public string Value { get; set; } =  string.Empty;
}