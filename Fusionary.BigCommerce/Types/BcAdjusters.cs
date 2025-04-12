namespace Fusionary.BigCommerce.Types;

public record BcAdjusters : BcExtensionData
{
    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    public BcAdjusterItem? Price { get; init; }

    /// <summary>
    /// Gets or Sets Weight
    /// </summary>
    public BcAdjusterItem? Weight { get; init; }

    /// <summary>
    /// The URL for an image displayed on the storefront when the modifier value is selected.
    /// </summary>
    public string? ImageUrl { get; init; }

    /// <summary>
    /// Gets or Sets PurchasingDisabled
    /// </summary>
    public BcAdjusterPurchasingDisabled? PurchasingDisabled { get; init; }
}