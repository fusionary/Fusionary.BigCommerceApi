namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Brand {Id}:{Name}")]
public record BcBrand : BcBrandPost
{
    public int Id { get; set; }
}
