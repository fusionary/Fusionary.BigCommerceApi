using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

using Fusionary.BigCommerce.Utils;

namespace Fusionary.BigCommerce;

public class BigCommerceApi : IBigCommerceApi
{
    private readonly IBigCommerceClient _bigCommerce;

    [SuppressMessage("ReSharper", "SuggestBaseTypeForParameterInConstructor")]
    public BigCommerceApi(BigCommerceClient bigCommerce) : this((IBigCommerceClient)bigCommerce) { }

    private BigCommerceApi(IBigCommerceClient bigCommerce)
    {
        _bigCommerce = bigCommerce;
    }

    public static IBigCommerceApi Create(IBigCommerceClient client) => new BigCommerceApi(client);

    public Task<T> DeleteAsync<T>(string path, CancellationToken cancellationToken) =>
        DeleteAsync<T>(path, QueryString.Empty, cancellationToken);

    public Task<T> DeleteAsync<T>(string path, QueryString queryString, CancellationToken cancellationToken) =>
        SendJsonResponseAsync<T>(HttpMethod.Delete, path, null, queryString, cancellationToken);

    public Task<bool> DeleteAsync(string path, CancellationToken cancellationToken) => DeleteAsync(path, QueryString.Empty, cancellationToken);

    public async Task<bool> DeleteAsync(string path, QueryString queryString, CancellationToken cancellationToken)
    {
        var requestMessage = CreateRequestMessage(HttpMethod.Delete, path, queryString);
        var response =  await SendAsync(requestMessage, cancellationToken);
        return response.StatusCode == HttpStatusCode.NoContent;
    }

    public Task<T> GetAsync<T>(string path, CancellationToken cancellationToken) =>
        GetAsync<T>(path, QueryString.Empty, cancellationToken);

    public Task<T> GetAsync<T>(string path, QueryString queryString, CancellationToken cancellationToken) =>
        SendJsonResponseAsync<T>(HttpMethod.Get, path, null, queryString, cancellationToken);

    public Task<T> SendJsonResponseAsync<T>(
        HttpMethod method,
        string path,
        QueryString queryString,
        CancellationToken cancellationToken
    ) =>
        SendJsonResponseAsync<T>(method, path, null, queryString, cancellationToken);

    public Task<T> PostAsync<T>(string path, object? payload, CancellationToken cancellationToken) =>
        PostAsync<T>(path, payload, QueryString.Empty, cancellationToken);

    public Task<T> PostAsync<T>(
        string path,
        object? payload,
        QueryString queryString,
        CancellationToken cancellationToken
    ) =>
        SendJsonResponseAsync<T>(HttpMethod.Post, path, payload, queryString, cancellationToken);

    public Task<T> PostAsync<T>(
        string path,
        MultipartFormDataContent content,
        CancellationToken cancellationToken
    ) =>
        PostAsync<T>(path, content, QueryString.Empty, cancellationToken);

    public Task<T> PostAsync<T>(
        string path,
        MultipartFormDataContent content,
        QueryString queryString,
        CancellationToken cancellationToken
    ) =>
        SendMultipartFormResponseAsync<T>(HttpMethod.Post, path, content, queryString, cancellationToken);

    public Task<T> PutAsync<T>(string path, object? payload, CancellationToken cancellationToken) =>
        PutAsync<T>(path, payload, QueryString.Empty, cancellationToken);

    public Task<T> PutAsync<T>(
        string path,
        object? payload,
        QueryString queryString,
        CancellationToken cancellationToken
    ) =>
        SendJsonResponseAsync<T>(HttpMethod.Put, path, payload, queryString, cancellationToken);

    public Task<T> SendJsonResponseAsync<T>(
        HttpMethod method,
        string path,
        object? payload,
        CancellationToken cancellationToken
    ) =>
        SendJsonResponseAsync<T>(method, path, payload, new QueryString(), cancellationToken);

    public async Task<T> SendMultipartFormResponseAsync<T>(
        HttpMethod method,
        string path,
        MultipartFormDataContent content,
        QueryString queryString,
        CancellationToken cancellationToken
    )
    {
        var requestMessage = CreateRequestMessage(method, path, queryString);

        requestMessage.Content = content;
        
        return await SendJsonResponseAsync<T>(requestMessage, cancellationToken);
    }
    
    public async Task<T> SendJsonResponseAsync<T>(
        HttpMethod method,
        string path,
        object? payload,
        QueryString queryString,
        CancellationToken cancellationToken
    )
    {
        var requestMessage = CreateRequestMessage(method, path, queryString);

        if (payload is not null)
        {
            requestMessage.Content = BcJsonUtil.CreateContent(payload);
        }

        return await SendJsonResponseAsync<T>(requestMessage, cancellationToken);
    }

    public static HttpRequestMessage CreateRequestMessage(
        HttpMethod method, 
        string path, 
        QueryString queryString = default)
    {
        if (queryString.HasValue) {
            path += queryString.ToUriComponent();
        }

        return new HttpRequestMessage(method, path);
    }

    public async Task<T> SendJsonResponseAsync<T>(
        HttpRequestMessage requestMessage,
        CancellationToken cancellationToken
    )
    {
        var response = await SendAsync(requestMessage, cancellationToken);

        response.EnsureSuccessStatusCode();

        var data = await response.Content.ReadFromJsonAsync<T>(BcJsonUtil.JsonOptions, cancellationToken: cancellationToken);

        if (data is null)
        {
            throw new ApplicationException($"Unable to deserialize response as type {typeof(T).FullName}");
        }

        return data;
    }

    public async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage requestMessage,
        CancellationToken cancellationToken
    )
    {
        var response = await _bigCommerce.Client.SendAsync(
            requestMessage, 
            cancellationToken)
            .ConfigureAwait(false);

        return response;
    }
}