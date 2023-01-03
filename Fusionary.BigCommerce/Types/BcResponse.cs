using JetBrains.Annotations;

namespace Fusionary.BigCommerce.Types;

[UsedImplicitly]
public abstract record BcResponse<TData, TMeta, TErrors> where TMeta : class, new()
{
    protected void Deconstruct(out TData data, out TMeta meta)
    {
        data = Data;
        meta = Meta;
    }

    private TMeta? _meta;
    private TErrors[]? _errors;

    [JsonPropertyName("data")]
    public TData Data { get; set; } = default!;

    [JsonPropertyName("errors")]
    public TErrors[] Errors
    {
        get => LazyInitializer.EnsureInitialized(ref _errors, Array.Empty<TErrors>);
        set => _errors = value;
    }

    [JsonPropertyName("meta")]
    public TMeta Meta
    {
        get => LazyInitializer.EnsureInitialized(ref _meta, () => new TMeta());
        set => _meta = value;
    }
}