using System.Net.Http.Headers;

using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;

using Microsoft.Extensions.Options;

namespace Fusionary.BigCommerce;

public class BcStorefrontGraphQL : IBcStorefrontGraphQL
{
    private readonly IOptions<BigCommerceConfig> _options;
    private readonly IBcTokenCache _tokenCache;

    public BcStorefrontGraphQL(IOptions<BigCommerceConfig> options, IBcTokenCache tokenCache)
    {
        _options = options;
        _tokenCache = tokenCache;
    }

    public async Task<GraphQLResponse<TResponse>> SendQueryAsync<TResponse>(
        GraphQLRequest request,
        BcGraphqlRequestOverride? requestOverride = default,
        CancellationToken cancellationToken = default
    )
    {
        var config = _options.Value;

        var client = await GetGraphQLHttpClientAsync(config, requestOverride, cancellationToken);

        return await client.SendQueryAsync<TResponse>(request, cancellationToken);
    }

    private async Task<string> GetAuthTokenAsync(
        string storefrontUrl,
        int? channelId,
        BcRequestOverride? requestOverride,
        CancellationToken cancellationToken
    )
    {
        var tokenRequest = new BcTokenRequest(
            TimeSpan.FromMinutes(10),
            storefrontUrl,
            channelId
        );

        var token = await _tokenCache.GetOrCreateTokenAsync(tokenRequest, requestOverride, cancellationToken);

        return token;
    }

    private static int? GetChannelId(BigCommerceConfig config, BcGraphqlRequestOverride? requestOverride) =>
        requestOverride?.ChannelId ?? config.StorefrontChannelId.GetValueOrDefault(1);

    private static string GetGraphQlEndpoint(string storefrontUrl) => $"{storefrontUrl}/graphql";

    private async Task<GraphQLHttpClient> GetGraphQLHttpClientAsync(
        BigCommerceConfig config,
        BcGraphqlRequestOverride? requestOverride,
        CancellationToken cancellationToken
    )
    {
        var options = GetRequestOptions(config, requestOverride);

        var storefrontUrl = GetStorefrontUrl(config, options);

        var channelId = GetChannelId(config, options);

        var token = await GetAuthTokenAsync(storefrontUrl, channelId, options, cancellationToken);

        var graphQLEndpoint = GetGraphQlEndpoint(storefrontUrl);

        var jsonSerializer = requestOverride?.ConfigureSerializerOptions is { } configure
            ? new SystemTextJsonSerializer(configure)
            : new SystemTextJsonSerializer();

        var client = new GraphQLHttpClient(graphQLEndpoint, jsonSerializer);

        client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        return client;
    }

    private static BcGraphqlRequestOverride? GetRequestOptions(
        BigCommerceConfig config,
        BcGraphqlRequestOverride? requestOverride
    )
    {
        var storefrontAccessToken = config.StorefrontAccessToken;

        if (string.IsNullOrWhiteSpace(storefrontAccessToken))
        {
            return requestOverride;
        }

        var overrideOptions = requestOverride ?? new BcGraphqlRequestOverride();

        if (!overrideOptions.Headers.ContainsKey(BcHeaderName.XAuthToken))
        {
            overrideOptions.Headers[BcHeaderName.XAuthToken] = storefrontAccessToken;
        }

        return overrideOptions;
    }

    private static string GetStorefrontUrl(BigCommerceConfig config, BcGraphqlRequestOverride? requestOverride)
    {
        var storefrontUrl = string.IsNullOrEmpty(requestOverride?.StorefrontUrl)
            ? config.StorefrontUrl
            : requestOverride.StorefrontUrl;

        return storefrontUrl.TrimEnd('/');
    }
}