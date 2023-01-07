namespace Fusionary.BigCommerce.Operations;

public abstract class BcMetafieldsUpdateBase : BcRequestBuilder
{
    protected BcMetafieldsUpdateBase(IBcApi api) : base(api)
    { }

    /// <summary>
    /// Gets the resource path for the request.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="metafieldId">The metafield id</param>
    protected abstract string MetafieldResourceEndpoint(object resourceId, object metafieldId);

    /// <summary>
    /// Updates a metafield for the specified resource.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="metafield">The metafield</param>
    /// <param name="cancellationToken"></param>
    public Task<BcResultData<BcMetafield>> SendAsync(
        object resourceId,
        BcMetafield metafield,
        CancellationToken cancellationToken
    ) => Api.PutDataAsync<BcMetafield>(
        MetafieldResourceEndpoint(resourceId, metafield.Id),
        metafield,
        Filter,
        Options,
        cancellationToken
    );

    /// <summary>
    /// Updates metafields for the specified resource.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="metafields">The metafields</param>
    /// <param name="cancellationToken"></param>
    public async Task<BcResultData<List<BcMetafield>>> SendAsync(
        object resourceId,
        IEnumerable<BcMetafield> metafields,
        CancellationToken cancellationToken
    )
    {
        var data = new List<BcMetafield>();

        BcRateLimitResponseHeaders rateLimits = default!;

        foreach (var metafield in metafields)
        {
            var (success, result, errorResult) =
                await SendItemAsync<BcMetafield>(resourceId, metafield, cancellationToken);

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
            object orderId,
            BcMetafield metafield,
            CancellationToken cancellationToken
        )
    {
        var result = await Api.PutDataAsync<T>(
            MetafieldResourceEndpoint(orderId, metafield.Id),
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