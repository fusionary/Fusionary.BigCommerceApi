namespace Fusionary.BigCommerce;

public static class BcApiGetDataExtensions
{
    public static async Task<BcResultData<T>> GetDataAsync<T>(
        this IBcApi api,
        string path,
        QueryString queryString = default,
        BcRequestOptions? options = default,
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
}