namespace Fusionary.BigCommerce.Types;

public record BcAdjusters: IExtensionData
{
    public BcAdjusterItem? Price { get; set; }

    public BcAdjusterItem? Weight { get; set; }

    public string? ImageUrl { get; set; }

    public BcAdjusterPurchasingDisabled? PurchasingDisabled { get; set; }

    /// <inheritdoc />
    public IDictionary<string, JsonElement>? ExtensionData { get; set; }
}
