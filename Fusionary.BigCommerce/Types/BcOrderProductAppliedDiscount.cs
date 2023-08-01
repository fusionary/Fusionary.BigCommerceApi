namespace Fusionary.BigCommerce.Types;

public record BcOrderProductAppliedDiscount
{
    /// <summary>
    /// Name of the coupon applied to order.
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// Amount of the discount.
    /// </summary>
    public BcFloat Amount { get; set; }

    /// <summary>
    /// Name of the coupon.
    /// </summary>
    /// <remarks>
    /// Use "Manual Discount" when creating a manual discount.
    /// </remarks>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Coupon Code. There is no code when creating a manual discount.
    /// </summary>
    /// <remarks>
    /// Use <c>null</c> when creating a manual discount.
    /// </remarks>
    public string? Code { get; set; }

    /// <summary>
    /// Determines if the discount if discount was applied at the Order or Product level. Read Only.
    /// </summary>
    public BcDiscountTarget Target { get; set; } = BcDiscountTarget.Order;
}