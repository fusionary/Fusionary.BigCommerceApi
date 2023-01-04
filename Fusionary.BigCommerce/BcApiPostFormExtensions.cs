namespace Fusionary.BigCommerce;

public static class BcApiPostFormExtensions
{
    public static Task<BcResult<TResult, TMeta>> PostFormAsync<TResult, TMeta>(
        this IBigCommerceApi api,
        string path,
        MultipartFormDataContent content,
        CancellationToken cancellationToken
    ) => api.PostFormAsync<TResult, TMeta>(path, content, QueryString.Empty, cancellationToken);

    public static Task<BcResult<TResult, TMeta>> PostFormAsync<TResult, TMeta>(
        this IBigCommerceApi api,
        string path,
        MultipartFormDataContent content,
        QueryString queryString,
        CancellationToken cancellationToken
    ) => api.SendMultipartFormRequestAsync<TResult, TMeta>(
        HttpMethod.Post,
        path,
        content,
        queryString,
        cancellationToken
    );
}