using JetBrains.Annotations;

namespace Fusionary.BigCommerce;

[UsedImplicitly]
public class BcResponse<TData>
{
    private BcMetadata? _meta;

    [JsonPropertyName("data")]
    public TData Data { get; set; } = default!;

    [JsonPropertyName("meta")]
    public BcMetadata Meta
    {
        get => LazyInitializer.EnsureInitialized(ref _meta, () => new BcMetadata());
        set => _meta = value;
    }
}