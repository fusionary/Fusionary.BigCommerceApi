namespace Fusionary.BigCommerce;

public static class ExtensionsForBcApiPost
{
    public static Task<BcResult<TResult, TMeta>> PostAsync<TResult, TMeta>(
        this IBcApi api,
        string path,
        object? payload,
        QueryString queryString = default,
        BcRequestOptions? options = null,
        CancellationToken cancellationToken = default
    ) => api.SendRequestAsync<TResult, TMeta>(HttpMethod.Post, path, payload, queryString, options, cancellationToken);
}