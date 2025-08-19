namespace Fusionary.BigCommerce.B2B.Types;

public record B2BInvoiceAddress
{
    [JsonPropertyName("city")]
    public string? City  { get; init; }
    [JsonPropertyName("state")]
    public string? State  { get; init; }
    [JsonPropertyName("country")]
    public string? Country { get; init; }
    [JsonPropertyName("street1")]
    public string? Street1 { get; init; }
    [JsonPropertyName("street2")]
    public string? Street2 { get; init; }
    [JsonPropertyName("zipCode")]
    public string? ZipCode { get; init; }
    [JsonPropertyName("lastName")]
    public string? LastName { get; init; }
    [JsonPropertyName("firstName")]
    public string? FirstName { get; init; }
}