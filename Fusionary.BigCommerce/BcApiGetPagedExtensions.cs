namespace Fusionary.BigCommerce;

public static class BcApiGetPagedExtensions
{
    public static Task<BcPagedResult<T>> GetPagedAsync<T>(
        this IBigCommerceApi api,
        string path,
        CancellationToken cancellationToken
    ) =>
        api.GetPagedAsync<T>(path, QueryString.Empty, cancellationToken);

    public static async Task<BcPagedResult<T>> GetPagedAsync<T>(
        this IBigCommerceApi api,
        string path,
        QueryString queryString,
        CancellationToken cancellationToken
    )
    {
        var result = await api.SendRequestAsync<List<T>, BcMetadataPagination>(
            HttpMethod.Get,
            path,
            null,
            queryString,
            cancellationToken
        );

        return result.AsPagedResult();
    }
}