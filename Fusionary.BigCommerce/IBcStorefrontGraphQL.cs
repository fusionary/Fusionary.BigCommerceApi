using GraphQL;

namespace Fusionary.BigCommerce;

public interface IBcStorefrontGraphQL
{
    Task<GraphQLResponse<TResponse>> SendQueryAsync<TResponse>(GraphQLRequest request, CancellationToken cancellationToken);
    Task<GraphQLResponse<TResponse>> SendQueryAsync<TResponse>(GraphQLRequest request, BcGraphqlRequestOverride? requestOverride, CancellationToken cancellationToken);
}