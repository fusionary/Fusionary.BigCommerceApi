namespace Fusionary.BigCommerce;

public static class ExtensionsForBcApiPutData
{
    public static async Task<BcResultData<T>> PutDataAsync<T>(
        this IBcApi api,
        string path,
        object? payload,
        QueryString queryString = default,
        BcRequestOptions? options = default,
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
}