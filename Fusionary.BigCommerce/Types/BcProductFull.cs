namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Product #{Id}: {Name} - {Sku}")]
public record BcProductFull : BcProductPost
{
    /// <summary>
    /// ID of the product. Read Only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int Id { get; set; }

    /// <summary>
    /// Custom fields.
    /// </summary>
    public new List<BcCustomField>? CustomFields { get; set; }

    /// <summary>
    /// Images
    /// </summary>
    public new List<BcProductImage>? Images { get; set; }

    /// <summary>
    /// Variants
    /// </summary>
    public new List<BcProductVariant>? Variants { get; set; }
}
