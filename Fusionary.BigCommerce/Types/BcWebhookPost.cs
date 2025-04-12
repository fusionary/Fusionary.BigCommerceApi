namespace Fusionary.BigCommerce.Types;

public record BcWebhookPost : BcExtensionData
{
    private Dictionary<string, string>? _headers;

    /// <summary>
    /// Event type to subscribe to. For example, "store/order/created".
    /// </summary>
    [JsonPropertyName("scope")]
    public string Scope { get; set; } = null!;

    /// <summary>
    /// URL must be publicly accessible and served on port 443 (HTTPS).
    /// </summary>
    [JsonPropertyName("destination")]
    public string Destination { get; set; } = null!;

    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }

    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers
    {
        get => LazyInitializer.EnsureInitialized(ref _headers);
        set => _headers = value;
    }
}