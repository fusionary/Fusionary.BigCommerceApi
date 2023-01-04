namespace Fusionary.BigCommerce;

public static class BcApiPutDataExtensions
{
    public static Task<BcDataResult<T>> PutDataAsync<T>(
        this IBigCommerceApi api,
        string path,
        object? payload,
        CancellationToken cancellationToken
    ) => api.PutDataAsync<T>(path, payload, QueryString.Empty, cancellationToken);

    public static async Task<BcDataResult<T>> PutDataAsync<T>(
        this IBigCommerceApi api,
        string path,
        object? payload,
        QueryString queryString,
        CancellationToken cancellationToken
    )
    {
        var result = await api.SendRequestAsync<T, BcMetadataEmpty>(
            HttpMethod.Put,
            path,
            payload,
            queryString,
            cancellationToken
        );

        return result.AsDataResult();
    }
}