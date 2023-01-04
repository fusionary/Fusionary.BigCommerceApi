namespace Fusionary.BigCommerce;

public static class BcApiDeleteExtensions
{
    public static Task<BcResult<TResult, TMeta>> DeleteAsync<TResult, TMeta>(
        this IBigCommerceApi api,
        string path,
        CancellationToken cancellationToken
    ) =>
        api.DeleteAsync<TResult, TMeta>(path, QueryString.Empty, cancellationToken);

    public static Task<BcResult<TResult, TMeta>> DeleteAsync<TResult, TMeta>(
        this IBigCommerceApi api,
        string path,
        QueryString queryString,
        CancellationToken cancellationToken
    ) =>
        api.SendRequestAsync<TResult, TMeta>(HttpMethod.Delete, path, null, queryString, cancellationToken);

    public static Task<BcResult> DeleteAsync(
        this IBigCommerceApi api,
        string path,
        CancellationToken cancellationToken
    ) =>
        api.DeleteAsync(path, QueryString.Empty, cancellationToken);

    public static async Task<BcResult> DeleteAsync(
        this IBigCommerceApi api,
        string path,
        QueryString queryString,
        CancellationToken cancellationToken
    )
    {
        var requestMessage = BcRequestMessageBuilder.CreateRequestMessage(HttpMethod.Delete, path, queryString);

        var response = await api.SendRequestAsync<bool, BcMetadataEmpty>(requestMessage, cancellationToken);

        return response;
    }
}