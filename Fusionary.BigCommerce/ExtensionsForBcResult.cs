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
            ResponseText = result.ResponseText,
            RequestMethod = result.RequestMethod,
            RequestUri = result.RequestUri,
            RequestBody = result.RequestBody
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
            ResponseText = result.ResponseText,
            RequestMethod = result.RequestMethod,
            RequestUri = result.RequestUri,
            RequestBody = result.RequestBody
        };
    
    public static BcResultDataWithMessage<T> AsDataResultWithMessage<T>(this BcResult<T, BcMetadataMessage> result) =>
        new()
        {
            Data = result.Data,
            Meta = result.Meta,
            Error = result.Error,
            StatusCode = result.StatusCode,
            Success = result.Success,
            RateLimits = result.RateLimits,
            ResponseText = result.ResponseText,
            RequestMethod = result.RequestMethod,
            RequestUri = result.RequestUri,
            RequestBody = result.RequestBody
        };

    public static BcResultDataBatch<T> AsDataResultBatch<T>(this BcResult<T, BcMetadataBatch> result) =>
        new()
        {
            Data = result.Data,
            Meta = result.Meta,
            Error = result.Error,
            StatusCode = result.StatusCode,
            Success = result.Success,
            RateLimits = result.RateLimits,
            ResponseText = result.ResponseText,
            RequestMethod = result.RequestMethod,
            RequestUri = result.RequestUri,
            RequestBody = result.RequestBody
        };
}