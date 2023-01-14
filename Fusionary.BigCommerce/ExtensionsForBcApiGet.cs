namespace Fusionary.BigCommerce;

public static class ExtensionsForBcApiGet
{
    public static Task<BcResult<TResult, TMeta>> GetAsync<TResult, TMeta>(
        this IBcApi api,
        string path,
        QueryString queryString = default,
        BcRequestOptions? options = default,
        CancellationToken cancellationToken = default
    ) => api.SendRequestAsync<TResult, TMeta>(HttpMethod.Get, path, null, queryString, options, cancellationToken);
}