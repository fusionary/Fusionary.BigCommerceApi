namespace Fusionary.BigCommerce.B2B.Types;

public class B2BCompanyUpdate : B2BCompany
{
    [JsonPropertyName("customerGroupId")]
    public int? CustomerGroupId { get; set; }
    [JsonPropertyName("addressLine1")]
    public string? AddressLine1 { get; set; }
    [JsonPropertyName("addressLine2")]
    public string? AddressLine2 { get; set; }
    [JsonPropertyName("city")]
    public string? City { get; set; }
    [JsonPropertyName("state")]
    public string? State { get; set; }
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    [JsonPropertyName("zipCode")]
    public string? ZipCode { get; set; }
}