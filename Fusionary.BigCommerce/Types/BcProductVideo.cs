namespace Fusionary.BigCommerce.Types;

/// <summary>
/// Product Video
/// </summary>
/// <remarks>
/// See https://developer.bigcommerce.com/api-reference/9a44d1aef1724-get-a-product-video
/// </remarks>
public record BcProductVideo
{
    /// <summary>
    /// The unique numeric ID of the product video; increments sequentially.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int Id { get; set; }

    /// <summary>
    /// The title for the video. If left blank, this will be filled in according to data on a host site.
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// The description for the video. If left blank, this will be filled in according to data on a host site.
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// The order in which the video will be displayed on the product page. Higher integers give the video a lower
    /// priority. When updating, if the video is given a lower priority, all videos with a sort_order the same as
    /// or greater than the video's new sort_order value will have their sort_orders reordered.
    /// </summary>
    public int SortOrder { get; set; }

    /// <summary>
    /// The video type (a short name of a host site).
    /// </summary>
    public BcProductVideoType Type { get; set; }

    /// <summary>
    /// The ID of the video on a host site.
    /// </summary>
    public string VideoId { get; set; } = null!;

    /// <summary>
    /// The unique numeric identifier for the product with which the image is associated.
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Length of the video. This will be filled in according to data on a host site.
    /// </summary>
    public string? Length { get; set; }
}
