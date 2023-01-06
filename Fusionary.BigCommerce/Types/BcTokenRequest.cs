namespace Fusionary.BigCommerce.Types;

public record BcTokenRequest
{
    public BcTokenRequest()
    { }

    public BcTokenRequest(TimeSpan expiresIn, string? corsOrigin, int? channelId)
    {
        AllowedCorsOrigins = string.IsNullOrWhiteSpace(corsOrigin)
            ? Array.Empty<string>()
            : new[] { corsOrigin };
        ChannelId = channelId.GetValueOrDefault(1);
        ExpiresAt = DateTimeOffset.UtcNow.Add(expiresIn).ToUnixTimeSeconds();
    }

    /// <summary>
    /// List of allowed domains for Cross-Origin Request Sharing. Currently only accepts a single element.
    /// </summary>
    public string[] AllowedCorsOrigins { get; set; } = null!;

    /// <summary>
    /// Channel ID for requested token
    /// </summary>
    public int ChannelId { get; set; }

    /// <summary>
    /// Unix timestamp seconds (UTC time) defining when the token should expire.
    /// </summary>
    public long ExpiresAt { get; set; }
}