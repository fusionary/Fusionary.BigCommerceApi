namespace Fusionary.BigCommerce;

public interface IBcTokenCache
{
    Task<string> GetOrCreateTokenAsync(BcTokenRequest tokenRequest, CancellationToken cancellationToken);

    Task<string> GetOrCreateTokenAsync(
        BcTokenRequest tokenRequest,
        BcRequestOverride? requestOverride,
        CancellationToken cancellationToken
    );
}