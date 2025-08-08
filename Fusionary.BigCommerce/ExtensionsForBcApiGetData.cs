namespace Fusionary.BigCommerce;

public static class ExtensionsForBcApiGetData
{
    public static async Task<BcResultData<T>> GetDataAsync<T>(
        this IBcApi api,
        string path,
        QueryString queryString = default,
        BcRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var result = await api.SendRequestAsync<T, BcMetadataEmpty>(
            HttpMethod.Get,
            path,
            null,
            queryString,
            options,
            cancellationToken
        );

        return result.AsDataResult();
    }
    
    public static async Task<BcResultDataWithMessage<T>> GetDataWithMessageAsync<T>(
        this IBcApi api,
        string path,
        QueryString queryString = default,
        BcRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var result = await api.SendRequestAsync<T, BcMetadataMessage>(
            HttpMethod.Get,
            path,
            null,
            queryString,
            options,
            cancellationToken
        );

        return result.AsDataResultWithMessage();
    }    
}