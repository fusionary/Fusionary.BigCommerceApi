namespace Fusionary.BigCommerce;

public static class BcApiPutExtensions
{
    public static Task<BcResult<TResult, TMeta>> PutAsync<TResult, TMeta>(
        this IBigCommerceApi api,
        string path,
        object? payload,
        CancellationToken cancellationToken
    ) => api.PutAsync<TResult, TMeta>(path, payload, QueryString.Empty, cancellationToken);

    public static Task<BcResult<TResult, TMeta>> PutAsync<TResult, TMeta>(
        this IBigCommerceApi api,
        string path,
        object? payload,
        QueryString queryString,
        CancellationToken cancellationToken
    ) => api.SendRequestAsync<TResult, TMeta>(HttpMethod.Put, path, payload, queryString, cancellationToken);
}