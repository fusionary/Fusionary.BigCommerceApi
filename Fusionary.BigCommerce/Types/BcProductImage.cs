namespace Fusionary.BigCommerce.Types;

/// <summary>
/// Product Image
/// </summary>
/// <remarks>
/// See https://developer.bigcommerce.com/api-reference/a1562ed4d26f6-get-a-product-image
/// </remarks>
public record BcProductImage : BcProductImagePut
{
    /// <summary>
    /// The local path to the original image file uploaded to BigCommerce. Limit of 1MB per file.
    /// </summary>
    public string? ImageFile { get; set; }

    /// <summary>
    /// The date on which the product image was modified.
    /// </summary>
    public string? DateModified { get; set; }
}