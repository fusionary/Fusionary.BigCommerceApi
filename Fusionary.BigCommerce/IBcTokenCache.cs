namespace Fusionary.BigCommerce;

public interface IBcTokenCache
{
    /// <summary>
    /// Creates a new token each time this method is called.
    /// </summary>
    Task<string> CreateTokenAsync(
        BcTokenRequest tokenRequest,
        BcRequestOverride? requestOverride = default,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets a cached token or creates a new one if it doesn't exist.
    /// </summary>
    Task<string> GetOrCreateTokenAsync(
        BcTokenRequest tokenRequest,
        BcRequestOverride? requestOverride = default,
        CancellationToken cancellationToken = default
    );
}