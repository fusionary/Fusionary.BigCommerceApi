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
        CancellationToken cancellationToken = default
    )
    {
        var response = await BigCommerceHttp.Client.SendAsync(
                requestMessage,
                cancellationToken
            )
            .ConfigureAwait(false);

        var rq = response.RequestMessage?.ToString();

        _logger.LogInformation("{Message}", rq);

        return response;
    }

    public async Task<BcResult<TResult, TMeta>> SendMultipartFormRequestAsync<TResult, TMeta>(
        HttpMethod method,
        string path,
        MultipartFormDataContent content,
        QueryString queryString = default,
        BcRequestOptions? options = default,
        CancellationToken cancellationToken = default
    )
    {
        var requestMessage = BcRequestMessageBuilder.CreateRequestMessage(method, path, queryString, options);

        requestMessage.Content = content;

        return await SendRequestAsync<TResult, TMeta>(requestMessage, cancellationToken);
    }

    public async Task<BcResult<TResult, TMeta>> SendRequestAsync<TResult, TMeta>(
        HttpMethod method,
        string path,
        object? payload,
        QueryString queryString = default,
        BcRequestOptions? options = default,
        CancellationToken cancellationToken = default
    )
    {
        var requestMessage = BcRequestMessageBuilder.CreateRequestMessage(method, path, queryString, options);

        if (payload is not null)
        {
            requestMessage.Content = BcJsonUtil.CreateContent(payload);
        }

        return await SendRequestAsync<TResult, TMeta>(requestMessage, cancellationToken);
    }

    /// <summary>
    /// Sends the API request to the server
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/12f38e7c7b656-api-status-codes
    /// </remarks>
    public async Task<BcResult<TResult, TMeta>> SendRequestAsync<TResult, TMeta>(
        HttpRequestMessage requestMessage,
        CancellationToken cancellationToken = default
    )
    {
        var response = await SendAsync(requestMessage, cancellationToken);

        switch (response)
        {
            case { StatusCode: HttpStatusCode.OK }:
            case { StatusCode: HttpStatusCode.Created }:
            case { StatusCode: HttpStatusCode.Accepted }:
            case { StatusCode: HttpStatusCode.NoContent }:
            case { StatusCode: HttpStatusCode.MultiStatus }:
                {
                    return await response.ReadResponseAsync<TResult, TMeta>(cancellationToken);
                }
            case { StatusCode: HttpStatusCode.TooManyRequests }:
                {
                    if (response.TryGetHeaderValue<int>(BcHeaderName.XRateLimitTimeResetMs, out var retryAfterMs))
                    {
                        return await RetryRequestAfterDelayAsync<TResult, TMeta>(
                            requestMessage,
                            retryAfterMs,
                            cancellationToken
                        );
                    }

                    break;
                }
        }

        return await response.ReadErrorResponseAsync<TResult, TMeta>(cancellationToken);
    }

    public static IBcApi Create(IBigCommerceClient client) =>
        Create(client, NullLogger.Instance);

    public static IBcApi Create(IBigCommerceClient client, ILogger logger) =>
        new BcApi(client, logger);

    private async Task<BcResult<TResult, TMeta>> RetryRequestAfterDelayAsync<TResult, TMeta>(
        HttpRequestMessage requestMessage,
        int retryAfterMs,
        CancellationToken cancellationToken = default
    )
    {
        _logger.LogWarning(
            "BigCommerce API rate limit exceeded. Waiting {RetryAfterMs}ms before retrying.",
            retryAfterMs
        );

        await Task.Delay(retryAfterMs, cancellationToken);

        return await SendRequestAsync<TResult, TMeta>(requestMessage, cancellationToken);
    }
}
