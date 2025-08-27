namespace Fusionary.BigCommerce.B2B.Types;

public record B2BUser
{
    [JsonPropertyName("id")]
    public int? Id { get; init; }
    [JsonPropertyName("firstName")]
    public string? FirstName { get; init; }
    [JsonPropertyName("lastName")]
    public string? LastName { get; init; }
    [JsonPropertyName("email")]
    public string? Email { get; init; }
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; init; }
    [JsonPropertyName("role")]
    public int? Role { get; init; }
    [JsonPropertyName("companyRoleId")]
    public int? CompanyRoleId { get; init; }
    [JsonPropertyName("uuid")]
    public string? Uuid { get; init; }
    [JsonPropertyName("companyId")]
    public int? CompanyId { get; init; }
    [JsonPropertyName("createdAt")]
    public int? CreatedAt { get; init; }
    [JsonPropertyName("updatedAt")]
    public int? UpdatedAt { get; init; }
    [JsonPropertyName("customerId")]
    public int? CustomerId { get; init; }
    [JsonPropertyName("companyRoleName")]
    public string? CompanyRoleName { get; init; }
}