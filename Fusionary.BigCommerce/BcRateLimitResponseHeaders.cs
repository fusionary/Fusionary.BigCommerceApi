namespace Fusionary.BigCommerce;

public record BcRateLimitResponseHeaders
{
    /// <summary>
    /// Details how many remaining requests your client can make in the current window before being rate limited.
    /// In this case, you would expect to be able to make 6 more requests in the next 3000 milliseconds; on the 7th
    /// request within 3000 milliseconds, you would be rate limited and would receive an HTTP 429 response.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/a0ddf08933ce4-api-best-practices#example-of-429-status-code
    /// </remarks>
    public int RequestsLeft { get; set; }


    /// <summary>
    /// Shows how many API requests are allowed in the current window for your client.
    /// </summary>
    public int RequestsQuota { get; set; }

    /// <summary>
    /// Shows how many milliseconds are remaining in the window.
    /// </summary>
    public int TimeResetMs { get; set; }

    /// <summary>
    /// Shows the size of your current rate limiting window.
    /// </summary>
    public int TimeWindowMs { get; set; }
}