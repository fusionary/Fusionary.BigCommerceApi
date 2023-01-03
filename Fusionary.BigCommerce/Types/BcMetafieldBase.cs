namespace Fusionary.BigCommerce.Types;

public record BcMetafieldBase
{
    public int Id { get; set; }

    public string PermissionSet { get; set; } = null!;

    public string Namespace { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string? Description { get; set; }

    public string? ResourceType { get; set; }

    public int ResourceId { get; set; }

    public string? DateCreated { get; set; }

    public string? DateModified { get; set; }
}