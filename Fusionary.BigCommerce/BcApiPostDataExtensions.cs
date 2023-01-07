namespace Fusionary.BigCommerce;

public static class BcApiPostDataExtensions
{
    public static async Task<BcResultData<T>> PostDataAsync<T>(
        this IBcApi api,
        string path,
        object? payload,
        QueryString queryString = default,
        BcRequestOptions? options = default,
        CancellationToken cancellationToken = default
    )
    {
        var result = await api.SendRequestAsync<T, BcMetadataEmpty>(
            HttpMethod.Post,
            path,
            payload,
            queryString,
            options,
            cancellationToken
        );

        return result.AsDataResult();
    }
}