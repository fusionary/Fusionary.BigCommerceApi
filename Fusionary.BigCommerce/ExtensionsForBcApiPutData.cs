namespace Fusionary.BigCommerce;

public static class ExtensionsForBcApiPutData
{
    public static async Task<BcResultData<T>> PutDataAsync<T>(
        this IBcApi api,
        string path,
        object? payload,
        QueryString queryString = default,
        BcRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var result = await api.SendRequestAsync<T, BcMetadataEmpty>(
            HttpMethod.Put,
            path,
            payload,
            queryString,
            options,
            cancellationToken
        );

        return result.AsDataResult();
    }
    
    public static async Task<BcResultDataBatch<T>> PutDataBatchAsync<T>(
        this IBcApi api,
        string path,
        object? payload,
        QueryString queryString = default,
        BcRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var result = await api.SendRequestAsync<T, BcMetadataBatch>(
            HttpMethod.Put,
            path,
            payload,
            queryString,
            options,
            cancellationToken
        );

        return result.AsDataResultBatch();
    }        
    
    public static async Task<BcResultDataWithMessage<T>> PutDataWithMessageAsync<T>(
        this IBcApi api,
        string path,
        object? payload,
        QueryString queryString = default,
        BcRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var result = await api.SendRequestAsync<T, BcMetadataMessage>(
            HttpMethod.Put,
            path,
            payload,
            queryString,
            options,
            cancellationToken
        );

        return result.AsDataResultWithMessage();
    }      
}