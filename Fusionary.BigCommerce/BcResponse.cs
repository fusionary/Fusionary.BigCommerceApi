using JetBrains.Annotations;

namespace Fusionary.BigCommerce;

[UsedImplicitly]
public class BcResponse<TData, TMeta> where TMeta: class, new()
{
    public void Deconstruct(out TData data, out TMeta meta)
    {
        data = Data;
        meta = Meta;
    }

    private TMeta? _meta;

    [JsonPropertyName("data")]
    public TData Data { get; set; } = default!;

    [JsonPropertyName("meta")]
    public TMeta Meta
    {
        get => LazyInitializer.EnsureInitialized(ref _meta, () => new TMeta());
        set => _meta = value;
    }
}