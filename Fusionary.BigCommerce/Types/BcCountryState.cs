namespace Fusionary.BigCommerce.Types;

public class BcCountryState
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("state")]
    public string StateName { get; set; } = string.Empty;
    
    [JsonPropertyName("state_abbreviation")]
    public string Abbreviation { get; set; } = string.Empty;
    
    [JsonPropertyName("country_id")]
    public int CountryId { get; set; }
}