namespace Fusionary.BigCommerce.Types;

public record BcProductOptionValue : IExtensionData
{
    /// <summary>
    /// The unique numerical ID of the option, increments sequentially.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The flag for preselecting a value as the default on the storefront. This field is not supported for swatch
    /// options/modifiers.
    /// </summary>
    public bool IsDefault { get; set; }

    /// <summary>
    /// The text display identifying the value on the storefront.
    /// </summary>
    /// <remarks>
    /// Required in a /POST.
    /// </remarks>
    public required string Label { get; set; }

    /// <summary>
    /// The order in which the value will be displayed on the product page.
    /// </summary>
    /// <remarks>
    /// Required in a /POST.
    /// </remarks>
    public required int SortOrder { get; set; }

    /// <summary>
    /// Extra data describing the value, based on the type of option or modifier with which the value is associated.
    /// The swatch type option can accept an array of colors, with up to three hexidecimal color keys; or an image_url,
    /// which is a full image URL path including protocol. The product list type option requires a product_id. The
    /// checkbox type option requires a boolean flag, called checked_value, to determine which value is considered to
    /// be the checked state. If no data is available, returns null.
    /// </summary>
    public Dictionary<string, object>? ValueData { get; set; }

    /// <inheritdoc />
    public IDictionary<string, JsonElement>? ExtensionData { get; init; }
}