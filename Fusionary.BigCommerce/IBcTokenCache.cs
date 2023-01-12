namespace Fusionary.BigCommerce;

public interface IBcTokenCache
{
    Task<string> GetOrCreateTokenAsync(
        BcTokenRequest tokenRequest,
        CancellationToken cancellationToken
    ) =>
        GetOrCreateTokenAsync(tokenRequest, null, cancellationToken);

    /// <summary>
    /// Gets a cached token or creates a new one if it doesn't exist.
    /// </summary>
    Task<string> GetOrCreateTokenAsync(
        BcTokenRequest tokenRequest,
        BcRequestOverride? requestOverride,
        CancellationToken cancellationToken
    );

    Task<string> CreateTokenAsync(
        BcTokenRequest tokenRequest,
        CancellationToken cancellationToken
    ) =>
        CreateTokenAsync(tokenRequest, null, cancellationToken);

    /// <summary>
    /// Creates a new token each time this method is called.
    /// </summary>
    Task<string> CreateTokenAsync(
        BcTokenRequest tokenRequest,
        BcRequestOverride? requestOverride,
        CancellationToken cancellationToken
    );
}