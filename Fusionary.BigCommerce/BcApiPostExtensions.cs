namespace Fusionary.BigCommerce;

public static class BcApiPostExtensions
{
    public static Task<BcResult<TResult, TMeta>> PostAsync<TResult, TMeta>(
        this IBigCommerceApi api,
        string path,
        object? payload,
        CancellationToken cancellationToken
    ) => api.PostAsync<TResult, TMeta>(path, payload, QueryString.Empty, cancellationToken);

    public static Task<BcResult<TResult, TMeta>> PostAsync<TResult, TMeta>(
        this IBigCommerceApi api,
        string path,
        object? payload,
        QueryString queryString,
        CancellationToken cancellationToken
    ) => api.SendRequestAsync<TResult, TMeta>(HttpMethod.Post, path, payload, queryString, cancellationToken);
}