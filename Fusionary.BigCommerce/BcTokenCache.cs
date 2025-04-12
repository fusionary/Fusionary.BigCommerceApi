using Microsoft.Extensions.Caching.Memory;

namespace Fusionary.BigCommerce;

public class BcTokenCache(IMemoryCache cache, IBcApi bc) : IBcTokenCache
{
    public async Task<string> GetOrCreateTokenAsync(
        BcTokenRequest tokenRequest,
        BcRequestOverride? requestOverride = null,
        CancellationToken cancellationToken = default
    )
    {
        var cacheKey = GenerateCacheKey(tokenRequest, requestOverride);

        var token = await cache.GetOrCreateAsync(
            cacheKey,
            async entry =>
            {
                entry.AbsoluteExpiration = DateTimeOffset.FromUnixTimeSeconds(tokenRequest.ExpiresAt)
                    .Subtract(TimeSpan.FromSeconds(30));

                return await CreateTokenAsync(tokenRequest, requestOverride, cancellationToken);
            }
        );

        return token!;
    }

    public async Task<string> CreateTokenAsync(
        BcTokenRequest tokenRequest,
        BcRequestOverride? requestOverride = null,
        CancellationToken cancellationToken = default
    )
    {
        var result = await bc
            .Storefront()
            .GetToken()
            .WithOverrides(requestOverride)
            .SendAsync(tokenRequest, cancellationToken);

        return result.Data.Token;
    }

    private static string GenerateCacheKey(BcTokenRequest tokenRequest, BcRequestOverride? requestOverride)
    {
        var keyParts = new List<string?>
        {
            tokenRequest.ChannelId.ToString(),
            string.Join("-", tokenRequest.AllowedCorsOrigins),
            requestOverride?.ToString()
        };

        return $"bc-token-{string.Join("-", keyParts.RemoveAll(string.IsNullOrWhiteSpace))}";
    }
}