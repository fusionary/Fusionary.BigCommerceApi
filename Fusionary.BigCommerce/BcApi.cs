using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Fusionary.BigCommerce;

public class BcApi : IBcApi
{
    private readonly ILogger _logger;

    [SuppressMessage("ReSharper", "SuggestBaseTypeForParameterInConstructor")]
    public BcApi(BigCommerceClient client, ILogger<BcApi> logger) : this(
        (IBigCommerceClient)client,
        logger
    )
    { }

    private BcApi(IBigCommerceClient client, ILogger logger)
    {
        BigCommerceHttp = client;
        _logger = logger;
    }

    public IBigCommerceClient BigCommerceHttp { get; }

    public async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage requestMessage,
        BcRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var client = options?.RequestOverrides?.IsB2B ?? false ? BigCommerceHttp.B2BClient : BigCommerceHttp.Client;
        var response = await client.SendAsync(
                requestMessage,
                cancellationToken
            )
            .ConfigureAwait(false);

        if (_logger.IsEnabled(LogLevel.Trace))
        {
            var rq = response.RequestMessage?.ToString();

            _logger.LogTrace("{Message}", rq);
        }

        return response;
    }

    public async Task<BcResult<TResult, TMeta>> SendMultipartFormRequestAsync<TResult, TMeta>(
        HttpMethod method,
        string path,
        MultipartFormDataContent content,
        QueryString queryString = default,
        BcRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var requestMessage = BcRequestMessageBuilder.CreateRequestMessage(method, path, queryString, options);

        requestMessage.Content = content;

        return await SendRequestAsync<TResult, TMeta>(requestMessage, options, cancellationToken);
    }

    public async Task<BcResult<TResult, TMeta>> SendRequestAsync<TResult, TMeta>(
        HttpMethod method,
        string path,
        object? payload,
        QueryString queryString = default,
        BcRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var requestMessage = BcRequestMessageBuilder.CreateRequestMessage(method, path, queryString, options);

        if (payload is not null)
        {
            requestMessage.Content = BcJsonUtil.CreateContent(payload);
        }

        return await SendRequestAsync<TResult, TMeta>(requestMessage, options, cancellationToken);
    }

    /// <summary>
    /// Sends the API request to the server
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/12f38e7c7b656-api-status-codes
    /// </remarks>
    public async Task<BcResult<TResult, TMeta>> SendRequestAsync<TResult, TMeta>(
        HttpRequestMessage requestMessage,
        BcRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await SendAsync(requestMessage, options, cancellationToken);

        return response switch
        {
            { StatusCode: HttpStatusCode.OK } or
                { StatusCode: HttpStatusCode.Created } or
                { StatusCode: HttpStatusCode.Accepted } or
                { StatusCode: HttpStatusCode.NoContent } or
                { StatusCode: HttpStatusCode.MultiStatus } =>
                await response.ReadResponseAsync<TResult, TMeta>(cancellationToken),
            _ => await response.ReadErrorResponseAsync<TResult, TMeta>(cancellationToken)
        };
    }
    
    public static IBcApi Create(IBigCommerceClient client) =>
        Create(client, NullLogger.Instance);

    public static IBcApi Create(IBigCommerceClient client, ILogger logger) =>
        new BcApi(client, logger);
}