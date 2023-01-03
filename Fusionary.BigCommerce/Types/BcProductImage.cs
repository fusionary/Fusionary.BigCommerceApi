namespace Fusionary.BigCommerce.Types;

public record BcProductImage
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public bool? IsThumbnail { get; set; }

    public int? SortOrder { get; set; }

    public string? Description { get; set; }

    public string? ImageFile { get; set; }

    public string? ImageUrl { get; set; }

    public string? UrlZoom { get; set; }

    public string? UrlStandard { get; set; }

    public string? UrlThumbnail { get; set; }

    public string? UrlTiny { get; set; }

    public string? DateModified { get; set; }
}