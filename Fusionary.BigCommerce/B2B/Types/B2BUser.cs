namespace Fusionary.BigCommerce.B2B.Types;

public record B2BUser
{
    public int? Id { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Email { get; init; }
    public string? PhoneNumber { get; init; }
    public int? Role { get; init; }
    public int? CompanyRoleId { get; init; }
    public string? Uuid { get; init; }
    public int? CompanyId { get; init; }
    public int? CreatedAt { get; init; }
    public int? UpdatedAt { get; init; }
    public int? CustomerId { get; init; }
    public string? CompanyRoleName { get; init; }
}