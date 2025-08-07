namespace Fusionary.BigCommerce.Types;

public class BcCountry
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("country")]
    public string CountryName { get; set; } = string.Empty;
    
    [JsonPropertyName("country_iso2")]
    public string CountryIso2Code { get; set;  } =string.Empty;
    
    [JsonPropertyName("country_iso3")]
    public string CountryIso3Code { get; set;  } =string.Empty;
}