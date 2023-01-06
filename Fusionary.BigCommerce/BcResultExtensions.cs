namespace Fusionary.BigCommerce;

public static class BcResultExtensions
{
    public static BcDataResult<T> AsDataResult<T>(this BcResult<T, BcMetadataEmpty> result) =>
        new()
        {
            Data = result.Data,
            Meta = new BcMetadataEmpty(),
            Error = result.Error,
            StatusCode = result.StatusCode,
            Success = result.Success,
            RateLimits = result.RateLimits,
            ResponseText = result.ResponseText
        };

    public static BcPagedResult<T> AsPagedResult<T>(this BcResult<List<T>, BcMetadataPagination> result) =>
        new()
        {
            Data = result.Data,
            Meta = result.Meta,
            Error = result.Error,
            StatusCode = result.StatusCode,
            Success = result.Success,
            RateLimits = result.RateLimits,
            ResponseText = result.ResponseText
        };
}