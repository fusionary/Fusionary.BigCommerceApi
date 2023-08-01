namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{Status}: {Message}")]
public record BcAdjusterPurchasingDisabled
{
    /// <summary>
    /// Flag for whether the modifier value disables purchasing when selected on the storefront. This can be used for
    /// temporarily disabling a particular modifier value.
    /// </summary>
    public bool Status { get; init; }

    /// <summary>
    /// The message displayed on the storefront when the purchasing disabled status is `true`.
    /// </summary>
    public string Message { get; init; } = null!;
}