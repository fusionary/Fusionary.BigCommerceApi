namespace Fusionary.BigCommerce.Types;

public record BcProductOption
{
    public int Id { get; set; }

    private Dictionary<string, string>? _valueData;

    public bool IsDefault { get; set; }

    public string Label { get; set; } = null!;

    public int SortOrder { get; set; }

    public Dictionary<string, string> ValueData
    {
        get => LazyInitializer.EnsureInitialized(ref _valueData);
        set => _valueData = value;
    }
}