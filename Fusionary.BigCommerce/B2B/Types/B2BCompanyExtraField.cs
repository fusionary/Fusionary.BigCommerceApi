namespace Fusionary.BigCommerce.B2B.Types;

public class B2BCompanyExtraField
{
    [JsonPropertyName("fieldName")]
    public string? FieldName { get; set; }
    
    [JsonPropertyName("fieldValue")]
    public string? FieldValue { get; set; }
    
    [JsonPropertyName("labelName")]
    public string? LabelName { get; set; }
    
    /// <summary>
    /// 0 = false, 1 = true
    /// </summary>
    [JsonPropertyName("isRequired")]
    public string? IsRequired { get; set; }
    
    /// <summary>
    /// 0 = Text, 1 = multi-line text, 2 = numbers, 3 = dropdown.
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
    
    /// <summary>
    /// 0 = Text, 1 = multi-line text, 2 = numbers, 3 = dropdown.
    /// </summary>
    [JsonPropertyName("fieldType")]
    public int? FieldType { get; set; }
}