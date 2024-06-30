namespace Fusionary.BigCommerce.Types;

public record BcProductPricingBatchInput
{
    /// <summary>
    /// The channel context that pricing should be evaluated within
    /// </summary>
    public required int ChannelId { get; init; }

    /// <summary>
    /// The currency of prices to be returned for this request
    /// </summary>
    public required string CurrencyCode { get; init; }

    /// <summary>
    /// The customer group relevant for any customer group pricing, tax values, etc.
    /// </summary>
    public int CustomerGroupId { get; init; }

    /// <summary>
    /// The items to fetch prices for
    /// </summary>
    public required BcProductPricingBatchItem[] Items { get; init; } = null!;
}