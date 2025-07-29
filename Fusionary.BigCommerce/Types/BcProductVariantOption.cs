namespace Fusionary.BigCommerce.Types;

/// <summary>
/// Product Variant Option
/// </summary>
/// <see href="https://developer.bigcommerce.com/docs/rest-catalog/product-variant-options" />
[DebuggerDisplay("{DisplayName}")]
public record BcProductVariantOption : BcExtensionData
{
    private BcProductOptionValue[]? _optionValues;

    /// <summary>
    /// The unique numerical ID of the option, increments sequentially.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// The unique numerical ID of the product to which the option belongs.
    /// </summary>
    [JsonPropertyName("product_id")]
    public int ProductId { get; set; }

    /// <summary>
    /// The name of the option shown on the storefront.
    /// </summary>
    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; } = null!;

    /// <summary>
    /// The type of option, which determines how it will display on the storefront. Acceptable values: radio_buttons,
    /// rectangles, dropdown, product_list, product_list_with_images, swatch. For reference, the former v2 API values are: RB =
    /// radio_buttons, RT = rectangles, S = dropdown, P = product_list, PI = product_list_with_images, CS = swatch.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    /// <summary>
    /// The values for option config can vary based on the Modifier created.
    /// </summary>
    [JsonPropertyName("config")]
    public BcOptionConfig Config { get; set; } = null!;

    /// <summary>
    /// Order in which the option is displayed on the storefront.
    /// </summary>
    [JsonPropertyName("sort_order")]
    public int SortOrder { get; set; }

    [JsonPropertyName("option_values")]
    public BcProductOptionValue[] OptionValues
    {
        get => LazyInitializer.EnsureInitialized(ref _optionValues, () => []);
        set => _optionValues = value;
    }

    /// <summary>
    /// Publicly available image url
    /// </summary>
    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }

    /// <summary>
    /// The unique option name, auto-generated from the display name, a timestamp, and the product ID.
    /// </summary>
    /// <example>Add-a-$5-Donation1535042499-187</example>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}