using GraphQL;

namespace Fusionary.BigCommerce;

public interface IBcStorefrontGraphQL
{
    Task<GraphQLResponse<TResponse>> SendQueryAsync<TResponse>(
        GraphQLRequest request,
        CancellationToken cancellationToken = default
    ) =>
        SendQueryAsync<TResponse>(request, null, cancellationToken);

    Task<GraphQLResponse<TResponse>> SendQueryAsync<TResponse>(
        GraphQLRequest request,
        BcGraphqlRequestOverride? requestOverride = null,
        CancellationToken cancellationToken = default
    );
}