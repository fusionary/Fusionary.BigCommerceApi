namespace Fusionary.BigCommerce;

public interface IBigCommerceApi
{
    Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage requestMessage,
        CancellationToken cancellationToken
    );

    Task<BcResult<TResult, TMeta>> SendMultipartFormRequestAsync<TResult, TMeta>(
        HttpMethod method,
        string path,
        MultipartFormDataContent content,
        QueryString queryString,
        CancellationToken cancellationToken
    );

    Task<BcResult<TResult, TMeta>> SendRequestAsync<TResult, TMeta>(
        HttpMethod method,
        string path,
        object? payload,
        QueryString queryString,
        CancellationToken cancellationToken
    );

    Task<BcResult<TResult, TMeta>> SendRequestAsync<TResult, TMeta>(
        HttpRequestMessage requestMessage,
        CancellationToken cancellationToken
    );

    IBigCommerceClient BigCommerceHttp { get; }
}