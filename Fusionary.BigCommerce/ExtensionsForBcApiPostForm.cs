namespace Fusionary.BigCommerce;

public static class ExtensionsForBcApiPostForm
{
    public static Task<BcResult<TResult, TMeta>> PostFormAsync<TResult, TMeta>(
        this IBcApi api,
        string path,
        MultipartFormDataContent content,
        QueryString queryString = default,
        BcRequestOptions? options = null,
        CancellationToken cancellationToken = default
    ) => api.SendMultipartFormRequestAsync<TResult, TMeta>(
        HttpMethod.Post,
        path,
        content,
        queryString,
        options,
        cancellationToken
    );
}