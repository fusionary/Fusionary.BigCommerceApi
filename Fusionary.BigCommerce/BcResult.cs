using System.ComponentModel;

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
    public BcErrorDetails Error { get; init; } = default!;

    /// <summary>
    /// <see langword="true" /> if the request has error information.
    /// </summary>
    [JsonIgnore]
    public bool HasError => !string.IsNullOrWhiteSpace(Error?.Title);

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

    /// <summary>
    /// The requested URI
    /// </summary>
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public Uri? RequestUri { get; init; }

    /// <summary>
    /// The body of the request (available only if Success is false)
    /// </summary>
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public string? RequestBody { get; init; }


    public void Deconstruct(out bool success, out BcErrorDetails? error)
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

/// <inheritdoc />
public record BcResult<TData, TMeta> : BcResult
{
    /// <summary>
    /// The data returned by the API
    /// </summary>
    /// <remarks>
    /// Not <see langword="null" /> if <see cref="HasData" /> is <see langword="true" />.
    /// </remarks>
    [JsonPropertyOrder(50)]
    public TData Data { get; init; } = default!;

    /// <summary>
    /// <see langword="true" /> if the request has data.
    /// </summary>
    [JsonIgnore]
    public bool HasData => Data is not null;

    /// <summary>
    /// The metadata returned by the API
    /// </summary>
    /// <remarks>
    /// Not <see langword="null" /> if <see cref="HasMeta" /> is <see langword="true" />.
    /// </remarks>
    [JsonPropertyOrder(60)]
    public TMeta Meta { get; init; } = default!;

    /// <summary>
    /// <see langword="true" /> if the request has metadata.
    /// </summary>
    [JsonIgnore]
    public bool HasMeta => Meta is not null;

    public void Deconstruct(out bool success, out TData data, out BcErrorDetails? error)
    {
        success = Success;
        error = Error;
        data = Data;
    }

    public void Deconstruct(out bool success, out TData data, out TMeta meta, out BcErrorDetails? error)
    {
        success = Success;
        error = Error;
        data = Data;
        meta = Meta;
    }

    public static implicit operator TData(BcResult<TData, TMeta> result) => result.Data;

    public static implicit operator bool(BcResult<TData, TMeta> result) => result.Success;

    public static implicit operator BcResult<TData, TMeta>(TData data) =>
        new() { Data = data, Success = true, StatusCode = HttpStatusCode.OK };
}
