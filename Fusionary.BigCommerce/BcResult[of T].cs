using System.Net;

namespace Fusionary.BigCommerce;

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

    public void Deconstruct(out bool success, out TData data, out BcErrorBase? error)
    {
        success = Success;
        error = Error;
        data = Data;
    }

    public void Deconstruct(out bool success, out TData data, out TMeta meta, out BcErrorBase? error)
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