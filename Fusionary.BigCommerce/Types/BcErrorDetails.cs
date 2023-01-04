namespace Fusionary.BigCommerce.Types;

public record BcErrorDetails : BcErrorBase
{
    private Dictionary<string, string>? _errors;

    public string? Instance { get; set; }

    public Dictionary<string, string> Errors
    {
        get => LazyInitializer.EnsureInitialized(ref _errors);
        set => _errors = value;
    }
}