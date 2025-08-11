namespace Fusionary.BigCommerce.B2B.Types;

public class B2BCompanyCreate : B2BCompany
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
    [JsonPropertyName("adminFirstName")]
    public string? AdminFirstName { get; set; }
    [JsonPropertyName("adminLastName")]
    public string? AdminLastName { get; set; }
    [JsonPropertyName("adminEmail")]
    public string? AdminEmail { get; set; }
    [JsonPropertyName("adminPhoneNumber")]
    public string? AdminPhoneNumber { get; set; }
    [JsonPropertyName("originChannelId")]
    public int? OriginChannelId { get; set; }
    [JsonPropertyName("channelIds")]
    public List<int>? channelIds { get; set; }
    [JsonPropertyName("acceptCreationEmail")]
    public bool? AcceptCreationEmail { get; set; }
}