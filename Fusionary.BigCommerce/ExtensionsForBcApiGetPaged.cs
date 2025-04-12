namespace Fusionary.BigCommerce;

public static class ExtensionsForBcApiGetPaged
{
    public static async Task<BcResultPaged<T>> GetPagedAsync<T>(
        this IBcApi api,
        string path,
        QueryString queryString = default,
        BcRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var result = await api.SendRequestAsync<List<T>, BcMetadataPagination>(
            HttpMethod.Get,
            path,
            null,
            queryString,
            options,
            cancellationToken
        );

        return result.AsPagedResult();
    }
}