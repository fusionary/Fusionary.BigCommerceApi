namespace Fusionary.BigCommerce;

public static class ExtensionsForBcResult
{
    public static BcResultData<T> AsDataResult<T>(this BcResult<T, BcMetadataEmpty> result) =>
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

    public static BcResultPaged<T> AsPagedResult<T>(this BcResult<List<T>, BcMetadataPagination> result) =>
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