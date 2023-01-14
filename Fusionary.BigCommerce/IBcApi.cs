namespace Fusionary.BigCommerce;

public interface IBcApi
{
    IBigCommerceClient BigCommerceHttp { get; }

    Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage requestMessage,
        CancellationToken cancellationToken = default
    );

    Task<BcResult<TResult, TMeta>> SendMultipartFormRequestAsync<TResult, TMeta>(
        HttpMethod method,
        string path,
        MultipartFormDataContent content,
        CancellationToken cancellationToken = default
    ) =>
        SendMultipartFormRequestAsync<TResult, TMeta>(method, path, content, default, default, cancellationToken);

    Task<BcResult<TResult, TMeta>> SendMultipartFormRequestAsync<TResult, TMeta>(
        HttpMethod method,
        string path,
        MultipartFormDataContent content,
        QueryString queryString = default,
        BcRequestOptions? options = default,
        CancellationToken cancellationToken = default
    );

    Task<BcResult<TResult, TMeta>> SendRequestAsync<TResult, TMeta>(
        HttpRequestMessage requestMessage,
        CancellationToken cancellationToken = default
    );

    Task<BcResult<TResult, TMeta>> SendRequestAsync<TResult, TMeta>(
        HttpMethod method,
        string path,
        QueryString queryString = default,
        CancellationToken cancellationToken = default
    ) =>
        SendRequestAsync<TResult, TMeta>(method, path, null, queryString, cancellationToken);

    Task<BcResult<TResult, TMeta>> SendRequestAsync<TResult, TMeta>(
        HttpMethod method,
        string path,
        object? payload,
        QueryString queryString = default,
        CancellationToken cancellationToken = default
    ) =>
        SendRequestAsync<TResult, TMeta>(method, path, payload, queryString, default, cancellationToken);

    Task<BcResult<TResult, TMeta>> SendRequestAsync<TResult, TMeta>(
        HttpMethod method,
        string path,
        object? payload,
        QueryString queryString = default,
        BcRequestOptions? options = default,
        CancellationToken cancellationToken = default
    );
}