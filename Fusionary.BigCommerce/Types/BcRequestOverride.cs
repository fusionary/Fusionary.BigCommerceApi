namespace Fusionary.BigCommerce.Types;

public record BcRequestOverride
{
    private Dictionary<string, string>? _headers;

    /// <summary>
    /// Override Storehash for this request
    /// </summary>
    public string? StoreHash { get; set; }

    public bool HasHeaders => _headers is { Count: > 0 };

    /// <summary>
    /// Override Headers for this request
    /// </summary>
    public Dictionary<string, string> Headers
    {
        get => LazyInitializer.EnsureInitialized(
            ref _headers,
            () => new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        );
        set => _headers = value;
    }

    public override string ToString() => $"{StoreHash}-{string.Join('-', Headers.Select(x => $"{x.Key}:{x.Value}"))}";
}