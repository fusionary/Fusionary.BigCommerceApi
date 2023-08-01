namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Brand {Id}:{Name}")]
public record BcBrand : BcBrandPost
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int Id { get; set; }
}
