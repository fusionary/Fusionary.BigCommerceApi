using System.Net;

namespace Fusionary.BigCommerce.Types;

public record BcMetaError
{
    private Dictionary<string, string>? _errors;

    public HttpStatusCode Status { get; set; }

    public string Title { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Instance { get; set; }

    public Dictionary<string, string> Errors
    {
        get => LazyInitializer.EnsureInitialized(ref _errors);
        set => _errors = value;
    }
}