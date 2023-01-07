namespace Fusionary.BigCommerce.Operations;

public abstract class BcMetafieldsCreateBase : BcRequestBuilder
{
    protected BcMetafieldsCreateBase(IBcApi api) : base(api)
    { }

    /// <summary>
    /// Gets the resource path for the request.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    protected abstract string MetafieldResourceEndpoint(object resourceId);

    /// <summary>
    /// Creates a metafield for the specified resource.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="metafield">The metafield</param>
    /// <param name="cancellationToken"></param>
    public Task<BcResultData<BcMetafield>> SendAsync(
        object resourceId,
        BcMetafieldPost metafield,
        CancellationToken cancellationToken
    ) => Api.PostDataAsync<BcMetafield>(
        MetafieldResourceEndpoint(resourceId),
        metafield,
        Filter,
        Options,
        cancellationToken
    );

    /// <summary>
    /// Creates metafields for the specified resource.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="permissionSet">Determines the visibility and writeability of the field by other API consumers.</param>
    /// <param name="metafieldNamespace">Namespace for the metafield, for organizational purposes.</param>
    /// <param name="metafields">The metafields</param>
    /// <param name="cancellationToken"></param>
    public async Task<BcResultData<List<BcMetafield>>> SendAsync(
        object resourceId,
        BcPermissionSet permissionSet,
        string metafieldNamespace,
        IEnumerable<BcMetafieldItem> metafields,
        CancellationToken cancellationToken
    )
    {
        var data = new List<BcMetafield>();

        BcRateLimitResponseHeaders rateLimits = default!;

        foreach (var metafield in metafields)
        {
            var (success, result, errorResult) = await SendItemAsync<BcMetafield>(
                resourceId,
                metafield.ToMetafieldPost(permissionSet, metafieldNamespace),
                cancellationToken
            );

            if (!success)
            {
                return errorResult;
            }

            data.Add(result.Data);
            rateLimits = result.RateLimits;
        }

        return new BcResultData<List<BcMetafield>>
        {
            Success = true, StatusCode = HttpStatusCode.OK, Data = data, RateLimits = rateLimits
        };
    }

    private async Task<(bool success, BcResultData<T> data, BcResultData<List<T>> errorResult)>
        SendItemAsync<T>(
            object resourceId,
            BcMetafieldPost metafield,
            CancellationToken cancellationToken
        )
    {
        var result = await Api.PostDataAsync<T>(
            MetafieldResourceEndpoint(resourceId),
            metafield,
            Filter,
            Options,
            cancellationToken
        );

        if (result.Success)
        {
            return (true, result, default!);
        }

        var errorResult = new BcResultData<List<T>>
        {
            Success = false,
            Error = result.Error,
            StatusCode = result.StatusCode,
            RateLimits = result.RateLimits,
            ResponseText = result.ResponseText
        };

        return (false, default!, errorResult);
    }
}