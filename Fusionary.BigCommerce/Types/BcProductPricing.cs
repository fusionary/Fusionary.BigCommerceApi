namespace Fusionary.BigCommerce.Types;

public record BcProductPricing : IExtensionData
{
    public int ProductId { get; init; }
    public int VariantId { get; init; }

    public BcProductPricingOptions[] Options { get; init; } = null!;

    public BcProductPricingRetailPrice RetailPrice { get; init; } = null!;

    public BcProductPricingSalePrice SalePrice { get; init; } = null!;

    public BcProductPricingMinimumAdvertisedPrice MinimumAdvertisedPrice { get; init; } = null!;

    public BcProductPricingPrice Price { get; init; } = null!;

    public BcProductPricingCalculatedPrice CalculatedPrice { get; init; } = null!;

    public BcProductPricingPriceRange PriceRange { get; init; } = null!;

    public BcProductPricingRetailPriceRange RetailPriceRange { get; init; } = null!;

    public BcProductPricingBulkPricingItem[] BulkPricing { get; init; } = null!;

    public IDictionary<string, JsonElement>? ExtensionData { get; init; }
}
