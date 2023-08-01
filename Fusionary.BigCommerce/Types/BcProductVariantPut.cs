namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Id: {Id} Sku: {Sku} Product ID: {ProductId}")]
public record BcProductVariantPut : BcProductVariantPost
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int Id { get; set; }
}
