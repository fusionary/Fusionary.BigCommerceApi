namespace Fusionary.BigCommerce.Types;

public class BcProductImage
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("product_id")]
    public int ProductId { get; set; }
    
    [JsonPropertyName("image_file")]
    public bool? IsThumbnail { get; set; }
    
    [JsonPropertyName("sort_order")]
    public int? SortOrder { get; set; }
    
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    [JsonPropertyName("image_file")]
    public string? ImageFile { get; set; }
    
    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }
    
    [JsonPropertyName("url_zoom")]
    public string? UrlZoom { get; set; }
    
    [JsonPropertyName("url_standard")]
    public string? UrlStandard { get; set; }
    
    [JsonPropertyName("url_thumbnail")]
    public string? UrlThumbnail { get; set; }
    
    [JsonPropertyName("url_tiny")]
    public string? UrlTiny { get; set; }
    
    [JsonPropertyName("date_modified")]
    public string? DateModified { get; set; }
}
