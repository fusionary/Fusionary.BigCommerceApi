namespace Fusionary.BigCommerce;

public static class BcApiPostDataExtensions
{
    public static Task<BcDataResult<T>> PostDataAsync<T>(
        this IBigCommerceApi api,
        string path,
        object? payload,
        CancellationToken cancellationToken
    ) => api.PostDataAsync<T>(path, payload, QueryString.Empty, cancellationToken);

    public static async Task<BcDataResult<T>> PostDataAsync<T>(
        this IBigCommerceApi api,
        string path,
        object? payload,
        QueryString queryString,
        CancellationToken cancellationToken
    )
    {
        var result = await api.SendRequestAsync<T, BcMetadataEmpty>(
            HttpMethod.Post,
            path,
            payload,
            queryString,
            cancellationToken
        );

        return result.AsDataResult();
    }
}