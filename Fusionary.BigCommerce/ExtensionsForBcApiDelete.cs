namespace Fusionary.BigCommerce;

public static class ExtensionsForBcApiDelete
{
    public static Task<BcResult<TResult, TMeta>> DeleteAsync<TResult, TMeta>(
        this IBcApi api,
        string path,
        QueryString queryString = default,
        BcRequestOptions? options = default,
        CancellationToken cancellationToken = default
    ) =>
        api.SendRequestAsync<TResult, TMeta>(HttpMethod.Delete, path, null, queryString, options, cancellationToken);

    public static async Task<BcResult> DeleteAsync(
        this IBcApi api,
        string path,
        QueryString queryString = default,
        BcRequestOptions? options = default,
        CancellationToken cancellationToken = default
    )
    {
        var requestMessage =
            BcRequestMessageBuilder.CreateRequestMessage(HttpMethod.Delete, path, queryString, options);

        var response = await api.SendRequestAsync<object?, BcMetadataEmpty>(requestMessage, cancellationToken);

        return response;
    }
}