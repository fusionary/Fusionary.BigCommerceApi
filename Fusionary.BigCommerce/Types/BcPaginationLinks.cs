namespace Fusionary.BigCommerce.Types;

public record BcPaginationLinks
{
    public string? Current { get; set; }

    public string? Previous { get; set; }

    public string? Next { get; set; }
}