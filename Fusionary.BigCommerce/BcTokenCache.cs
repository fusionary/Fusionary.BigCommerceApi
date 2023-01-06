using Microsoft.Extensions.Caching.Memory;

namespace Fusionary.BigCommerce;

public class BcTokenCache : IBcTokenCache
{
    private readonly Bc _bc;
    private readonly IMemoryCache _cache;

    public BcTokenCache(IMemoryCache cache, Bc bc)
    {
        _cache = cache;
        _bc = bc;
    }

    public Task<string> GetOrCreateTokenAsync(BcTokenRequest tokenRequest, CancellationToken cancellationToken) =>
        GetOrCreateTokenAsync(tokenRequest, default, cancellationToken);

    public async Task<string> GetOrCreateTokenAsync(
        BcTokenRequest tokenRequest,
        BcRequestOverride? requestOverride,
        CancellationToken cancellationToken
    )
    {
        var keyParts = new List<string?>
        {
            tokenRequest.ChannelId.ToString(),
            string.Join("-", tokenRequest.AllowedCorsOrigins),
            requestOverride?.StoreHash,
            requestOverride?.AccessToken
        };

        var cacheKey = $"bc-token-{string.Join("-", keyParts.RemoveAll(string.IsNullOrWhiteSpace))}";

        return await _cache.GetOrCreateAsync(
            cacheKey,
            async entry =>
            {
                entry.AbsoluteExpiration = DateTimeOffset.FromUnixTimeSeconds(tokenRequest.ExpiresAt);

                var result = await _bc.Storefront()
                    .GetToken()
                    .WithOverrides(requestOverride)
                    .SendAsync(tokenRequest, cancellationToken);

                return result.Data.Token;
            }
        );
    }
}