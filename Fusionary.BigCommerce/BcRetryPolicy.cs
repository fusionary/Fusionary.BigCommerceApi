using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Polly;
using Polly.Retry;

namespace Fusionary.BigCommerce;

public static class BcRetryPolicy
{
    public static AsyncRetryPolicy<HttpResponseMessage> CreateBigCommerceRetryPolicy(IServiceProvider serviceProvider)
    {
        var logger = serviceProvider.GetRequiredService<ILogger<object>>();
        
        return Policy.HandleResult<HttpResponseMessage>(response => response.StatusCode == HttpStatusCode.TooManyRequests)
            .WaitAndRetryAsync(
                3,
                (retryAttempt, response, _) =>
                {
                    if (response is { Result.Headers: not null } && response.Result.TryGetHeaderValue<int>(
                            BcHeaderName.XRateLimitTimeResetMs,
                            out var timeResetMs
                        ))
                    {
                        return TimeSpan.FromMilliseconds(timeResetMs * retryAttempt);
                    }

                    return TimeSpan.FromSeconds(Math.Pow(2, retryAttempt));
                },
                (response, timespan, retryCount, _) =>
                {
                    var responseMessage = response.Result;

                    logger.LogWarning(
                        """
                        BigCommerce API rate limit exceeded.

                        Received {StatusCode}. Retrying in {Delay}s (attempt {RetryCount})
                        """,
                        responseMessage.StatusCode,
                        timespan.TotalSeconds,
                        retryCount
                    );

                    return Task.CompletedTask;
                }
            );
    }
}