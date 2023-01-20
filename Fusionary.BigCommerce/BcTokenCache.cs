using Microsoft.Extensions.Caching.Memory;

namespace Fusionary.BigCommerce;

public class BcTokenCache : IBcTokenCache
{
    private readonly IBcApi _bc;
    private readonly IMemoryCache _cache;

    public BcTokenCache(IMemoryCache cache, IBcApi bc)
    {
        _cache = cache;
        _bc = bc;
    }

    public async Task<string> GetOrCreateTokenAsync(
        BcTokenRequest tokenRequest,
        BcRequestOverride? requestOverride = default,
        CancellationToken cancellationToken = default
    )
    {
        var cacheKey = GenerateCacheKey(tokenRequest, requestOverride);

        string? token =  await _cache.GetOrCreateAsync(
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

    private static string GenerateCacheKey(BcTokenRequest tokenRequest, BcRequestOverride? requestOverride)
    {
        var keyParts = new List<string?> {
            tokenRequest.ChannelId.ToString(),
            string.Join("-", tokenRequest.AllowedCorsOrigins),
            requestOverride?.ToString()
        };

        return $"bc-token-{string.Join("-", keyParts.RemoveAll(string.IsNullOrWhiteSpace))}";
    }

    public async Task<string> CreateTokenAsync(
        BcTokenRequest tokenRequest,
        BcRequestOverride? requestOverride = default,
        CancellationToken cancellationToken = default
    )
    {
        var result = await _bc
            .Storefront()
            .GetToken()
            .WithOverrides(requestOverride)
            .SendAsync(tokenRequest, cancellationToken);

        return result.Data.Token;
    }
}