namespace Fusionary.BigCommerce.Types;

public record BcProductVideo
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int SortOrder { get; set; }

    public string Type { get; set; } = null!;

    public string VideoId { get; set; } = null!;

    public int ProductId { get; set; }

    public string? Length { get; set; }
}