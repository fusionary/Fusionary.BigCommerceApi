namespace Fusionary.BigCommerce;

public static class ExtensionsForBcApiPut
{
    public static Task<BcResult<TResult, TMeta>> PutAsync<TResult, TMeta>(
        this IBcApi api,
        string path,
        object? payload,
        QueryString queryString = default,
        BcRequestOptions? options = default,
        CancellationToken cancellationToken = default
    ) => api.SendRequestAsync<TResult, TMeta>(HttpMethod.Put, path, payload, queryString, options, cancellationToken);
}