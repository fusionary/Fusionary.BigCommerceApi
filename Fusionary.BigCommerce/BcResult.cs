using System.Diagnostics;
using System.Net;

namespace Fusionary.BigCommerce;

[DebuggerDisplay("{StatusCode}")]
public record BcResult
{
    public bool Success { get; init; }

    public BcErrorBase? Error { get; init; } = default!;

    [JsonIgnore]
    public bool HasError => Error is not null;

    [JsonIgnore]
    public string? ResponseText { get; init; }

    public HttpStatusCode StatusCode { get; init; }

    public void Deconstruct(out bool success, out BcErrorBase? error)
    {
        success = Success;
        error = Error;
    }

    public static implicit operator bool(BcResult result) => result.Success;
}