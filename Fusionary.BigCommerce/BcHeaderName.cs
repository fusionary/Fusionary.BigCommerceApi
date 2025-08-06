namespace Fusionary.BigCommerce;

/// <summary>
/// Custom headers used by BigCommerce API
/// </summary>
/// <remarks>
/// See https://developer.bigcommerce.com/docs/3eea0e31b4c6a-about-our-ap-is#response-headers
/// </remarks>
public static class BcHeaderName
{
    /// <summary>
    /// Access token authorizing the app to access resources on behalf of a user.
    /// </summary>
    public const string XAuthToken = "X-Auth-Token";

    /// <summary>
    /// Access token header for B2B API, cuz of course it's different.
    /// </summary>
    public const string B2BAuthToken = "authToken";

    /// <summary>
    /// The number of API requests remaining for the current period (rolling one hour).
    /// </summary>
    public const string XBcApiLimitRemaining = "X-BC-ApiLimit-Remaining";

    /// <summary>
    /// The version of BigCommerce on which the store is running. This header is available on versions 7.3.6+.
    /// </summary>
    public const string XBcStoreVersion = "X-BC-Store-Version";

    /// <summary>
    /// Details how many remaining requests your client can make in the current window before being rate-limited.
    /// </summary>
    public const string XRateLimitRequestsLeft = "X-Rate-Limit-Requests-Left";

    /// <summary>
    /// Shows how many API requests are allowed in the current window for your client.
    /// </summary>
    public const string XRateLimitRequestsQuota = "X-Rate-Limit-Requests-Quota";

    /// <summary>
    /// Shows how many milliseconds are remaining in the window.
    /// </summary>
    public const string XRateLimitTimeResetMs = "X-Rate-Limit-Time-Reset-Ms";

    /// <summary>
    /// Shows the size of your current rate-limiting window.
    /// </summary>
    public const string XRateLimitTimeWindowMs = "X-Rate-Limit-Time-Window-Ms";

    /// <summary>
    /// Rate limited response, indicating the number of seconds before the quota refreshes.
    /// </summary>
    public const string XRetryAfter = "X-Retry-After";

    /// <summary>
    /// Header that determines whether the Batch API operates in strict mode or not. Strict mode will reject the entire request
    /// if any item in the batch has an error.
    /// </summary>
    public const string XStrictMode = "X-Strict-Mode";
}