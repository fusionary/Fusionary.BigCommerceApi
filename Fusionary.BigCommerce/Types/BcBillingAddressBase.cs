namespace Fusionary.BigCommerce.Types;

public record BcBillingAddressBase
{
    private List<BcNameValue>? _formFields;

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }
    
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }
    
    [JsonPropertyName("company")]
    public string? Company { get; set; }
    
    [JsonPropertyName("street_1")]
    public string? Street1 { get; set; }
    
    [JsonPropertyName("street_2")]
    public string? Street2 { get; set; }
    
    [JsonPropertyName("city")]
    public string? City { get; set; }
    
    [JsonPropertyName("state")]
    public string? State { get; set; }
    
    [JsonPropertyName("zip")]
    public string Zip { get; set; } = null!;
    
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    
    [JsonPropertyName("country_iso2")]
    public string? CountryIso2 { get; set; }
    
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }
    
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    
    [JsonPropertyName("form_fields")]
    public List<BcNameValue> FormFields
    {
        get => LazyInitializer.EnsureInitialized(ref _formFields);
        set => _formFields = value;
    }
}