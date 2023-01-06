using System.Diagnostics;
using System.Net;

namespace Fusionary.BigCommerce;

[DebuggerDisplay("{StatusCode}")]
public record BcResult
{
    /// <summary>
    /// <see langword="true" /> if the request was successful.
    /// </summary>
    [JsonPropertyOrder(1)]
    public bool Success { get; init; }

    /// <summary>
    /// Error information about the request.
    /// </summary>
    /// <remarks>
    /// Not <see langword="null" /> if <see cref="HasError" /> is <see langword="true" />.
    /// </remarks>
    [JsonPropertyOrder(99)]
    public BcErrorBase? Error { get; init; } = default!;

    /// <summary>
    /// <see langword="true" /> if the request has error information.
    /// </summary>
    [JsonIgnore]
    public bool HasError => Error is not null;

    /// <summary>
    /// The raw content of the API response.
    /// </summary>
    [JsonIgnore]
    public string? ResponseText { get; init; }

    /// <summary>
    /// The HTTP status code of the response.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/12f38e7c7b656-api-status-codes
    /// </remarks>
    [JsonPropertyOrder(2)]
    [JsonConverter(typeof(SerializePropertyAsDefaultConverter<HttpStatusCode>))]
    public HttpStatusCode StatusCode { get; init; }

    /// <summary>
    /// Each request to the API consumes one available request from the quota. When an app hits the quota limit,
    /// subsequent requests are rejected until the quota is refreshed.
    /// </summary>
    [JsonPropertyOrder(3)]
    public BcRateLimitResponseHeaders RateLimits { get; set; } = null!;

    public void Deconstruct(out bool success, out BcErrorBase? error)
    {
        success = Success;
        error = Error;
    }

    /// <summary>
    /// Implicitly converts a <see cref="BcResult" /> to a <see cref="bool" />.
    /// </summary>
    /// <remarks>
    /// For those of you that like javascript-style truthy statements.
    /// </remarks>
    public static implicit operator bool(BcResult result) => result.Success;
}