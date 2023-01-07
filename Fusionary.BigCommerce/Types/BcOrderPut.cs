namespace Fusionary.BigCommerce.Types;

public record BcOrderPut : BcOrderPost
{
    private List<BcOrderCatalogProductPut>? _products;

    public int Id { get; set; }

    [JsonPropertyName("products")]
    public new List<BcOrderCatalogProductPut> Products
    {
        get => LazyInitializer.EnsureInitialized(ref _products);
        set => _products = value;
    }
}