namespace Fusionary.BigCommerce;

public static class BcApiGetDataExtensions
{
    public static Task<BcDataResult<T>> GetDataAsync<T>(
        this IBigCommerceApi api,
        string path,
        CancellationToken cancellationToken
    ) =>
        api.GetDataAsync<T>(path, QueryString.Empty, cancellationToken);

    public static async Task<BcDataResult<T>> GetDataAsync<T>(
        this IBigCommerceApi api,
        string path,
        QueryString queryString,
        CancellationToken cancellationToken
    )
    {
        var result = await api.SendRequestAsync<T, BcMetadataEmpty>(
            HttpMethod.Get,
            path,
            null,
            queryString,
            cancellationToken
        );

        return result.AsDataResult();
    }
}