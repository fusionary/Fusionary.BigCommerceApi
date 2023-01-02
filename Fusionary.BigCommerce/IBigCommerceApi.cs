namespace Fusionary.BigCommerce;

public interface IBigCommerceApi
{
    Task<T> DeleteAsync<T>(string path, CancellationToken cancellationToken);

    Task<T> DeleteAsync<T>(string path, QueryString queryString, CancellationToken cancellationToken);

    Task<T> GetAsync<T>(string path, CancellationToken cancellationToken);

    Task<T> GetAsync<T>(string path, QueryString queryString, CancellationToken cancellationToken);

    Task<T> SendJsonResponseAsync<T>(
        HttpMethod method,
        string path,
        QueryString queryString,
        CancellationToken cancellationToken
    );

    Task<T> PostAsync<T>(string path, object? payload, CancellationToken cancellationToken);

    Task<T> PostAsync<T>(string path, object? payload, QueryString queryString, CancellationToken cancellationToken);

    Task<T> PutAsync<T>(string path, object? payload, CancellationToken cancellationToken);

    Task<T> PutAsync<T>(string path, object? payload, QueryString queryString, CancellationToken cancellationToken);

    Task<T> SendJsonResponseAsync<T>(
        HttpMethod method,
        string path,
        object? payload,
        CancellationToken cancellationToken
    );

    Task<T> SendJsonResponseAsync<T>(
        HttpMethod method,
        string path,
        object? payload,
        QueryString queryString,
        CancellationToken cancellationToken
    );

    Task<T> SendJsonResponseAsync<T>(HttpRequestMessage requestMessage, CancellationToken cancellationToken);

    Task<bool> DeleteAsync(string path, CancellationToken cancellationToken);

    Task<bool> DeleteAsync(string path, QueryString queryString, CancellationToken cancellationToken);

    Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage requestMessage,
        CancellationToken cancellationToken
    );
}