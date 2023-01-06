namespace Fusionary.BigCommerce.Types;

/// <summary>
/// Product Image
/// </summary>
/// <remarks>
/// See https://developer.bigcommerce.com/api-reference/a1562ed4d26f6-get-a-product-image
/// </remarks>
public record BcProductImage
{
    /// <summary>
    /// The unique numeric ID of the image; increments sequentially.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The unique numeric identifier for the product with which the image is associated.
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Flag for identifying whether the image is used as the product's thumbnail.
    /// </summary>
    public bool? IsThumbnail { get; set; }

    /// <summary>
    /// The order in which the image will be displayed on the product page. Higher integers give the image a lower
    /// priority. When updating, if the image is given a lower priority, all images with a sort_order the same as or
    /// greater than the image's new sort_order value will have their sort_orders reordered.
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// The description for the image.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The local path to the original image file uploaded to BigCommerce. Limit of 1MB per file.
    /// </summary>
    public string? ImageFile { get; set; }

    /// <summary>
    /// Must be a fully qualified URL path, including protocol. Limit of 8MB per file.
    /// </summary>
    public string? ImageUrl { get; set; }

    /// <summary>
    /// The zoom URL for this image. By default, this is used as the zoom image on product pages when zoom images
    /// are enabled.
    /// </summary>
    public string? UrlZoom { get; set; }

    /// <summary>
    /// The standard URL for this image. By default, this is used for product-page images.
    /// </summary>
    public string? UrlStandard { get; set; }

    /// <summary>
    /// The thumbnail URL for this image. By default, this is the image size used on the category page and in
    /// side panels.
    /// </summary>
    public string? UrlThumbnail { get; set; }

    /// <summary>
    /// The tiny URL for this image. By default, this is the image size used for thumbnails beneath the product image
    /// on a product page.
    /// </summary>
    public string? UrlTiny { get; set; }

    /// <summary>
    /// The date on which the product image was modified.
    /// </summary>
    public string? DateModified { get; set; }
}