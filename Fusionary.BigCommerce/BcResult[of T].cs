using System.Net;

namespace Fusionary.BigCommerce;

public record BcResult<TData, TMeta> : BcResult
{
    public TData Data { get; init; } = default!;

    public bool HasData => Data is not null;

    public TMeta Meta { get; init; } = default!;

    public bool HasMeta => Meta is not null;

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