namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Id: {Id} Sku: {Sku} Product ID: {ProductId}")]
public record BcProductVariant : BcProductVariantPut
{
    /// <summary>
    /// The price of the variant as seen on the storefront. This price takes into account sale_price and any price
    /// adjustment rules that are applicable to this variant.
    /// </summary>
    public BcFloat CalculatedPrice { get; set; }

    public BcFloat? CalculatedWeight { get; set; }
}