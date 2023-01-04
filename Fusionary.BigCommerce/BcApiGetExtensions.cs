namespace Fusionary.BigCommerce;

public static class BcApiGetExtensions
{
    public static Task<BcResult<TResult, TMeta>> GetAsync<TResult, TMeta>(
        this IBigCommerceApi api,
        string path,
        CancellationToken cancellationToken
    ) => api.GetAsync<TResult, TMeta>(path, QueryString.Empty, cancellationToken);

    public static Task<BcResult<TResult, TMeta>> GetAsync<TResult, TMeta>(
        this IBigCommerceApi api,
        string path,
        QueryString queryString,
        CancellationToken cancellationToken
    ) => api.SendRequestAsync<TResult, TMeta>(HttpMethod.Get, path, null, queryString, cancellationToken);
}