namespace Fusionary.BigCommerce.Types;

public record BcOrderPut : BcOrderPost
{
    private List<BcOrderCatalogProductPut>? _products;

    [JsonPropertyName("products")]
    public new List<BcOrderCatalogProductPut> Products
    {
        get => LazyInitializer.EnsureInitialized(ref _products);
        set => _products = value;
    }
}