namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Category {Name}")]
public record BcCategoryPost : IBcExtensionData
{
    /// <summary>
    /// The unique numeric ID of the category's parent. This field controls where the category sits in the tree of categories
    /// that organize the catalog. Required in a POST if creating a child category.
    /// </summary>
    [JsonPropertyName("parent_id")]
    public int ParentId { get; set; }

    /// <summary>
    /// The name displayed for the category. Name is unique with respect to the category's siblings. Required in a POST.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// The product description, which can include HTML formatting.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Priority this category will be given when included in the menu and category pages. The lower the number, the closer to
    /// the top of the results the category will be.
    /// </summary>
    [JsonPropertyName("sort_order")]
    public int? SortOrder { get; set; }

    /// <summary>
    /// Number of views the category has on the storefront.
    /// </summary>
    [JsonPropertyName("views")]
    public int? Views { get; set; }

    /// <summary>
    /// Custom title for the category page. If not defined, the category name will be used as the meta title.
    /// </summary>
    [JsonPropertyName("page_title")]
    public string? PageTitle { get; set; }

    /// <summary>
    /// Custom meta keywords for the category page. If not defined, the store's default keywords will be used
    /// </summary>
    [JsonPropertyName("meta_keywords")]
    public List<string>? MetaKeywords { get; set; }

    /// <summary>
    /// Custom meta description for the category page. If not defined, the store's default meta description will be used.
    /// </summary>
    [JsonPropertyName("meta_description")]
    public string? MetaDescription { get; set; }

    /// <summary>
    /// A comma-separated list of keywords that can be used to locate the category when searching the store.
    /// </summary>
    /// <remarks>
    /// &gt;= 0 characters &lt;= 255 characters
    /// </remarks>
    [JsonPropertyName("search_keywords")]
    public string? SearchKeywords { get; set; }

    /// <summary>
    /// Flag to determine whether the category should be displayed to customers browsing the store. If true, the category will
    /// be displayed. If false, the category will be hidden from view.
    /// </summary>
    [JsonPropertyName("is_visible")]
    public bool? IsVisible { get; set; }

    /// <summary>
    /// Image URL used for this category on the storefront. Images can be uploaded via form file post to
    /// /categories/{categoryId}/image, or by providing a publicly accessible URL in this field.
    /// </summary>
    /// <example>
    /// https://cdn8.bigcommerce.com/s-123456/product_images/d/fakeimage.png
    /// </example>
    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }

    /// <summary>
    /// The custom URL for the category on the storefront.
    /// </summary>
    [JsonPropertyName("custom_url")]
    public BcCustomUrl? CustomUrl { get; set; }

    /// <inheritdoc />
    public IDictionary<string, JsonElement>? ExtensionData { get; init; }
}