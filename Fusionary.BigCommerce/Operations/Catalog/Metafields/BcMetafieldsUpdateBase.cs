namespace Fusionary.BigCommerce.Operations;

public abstract class BcMetafieldsUpdateBase(IBcApi api) : BcRequestBuilder(api)
{
    /// <summary>
    /// Gets the resource path for the request.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="metafieldId">The metafield id</param>
    protected abstract string MetafieldResourceEndpoint(BcId resourceId, BcId metafieldId);

    /// <summary>
    /// Updates a metafield for the specified resource.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="metafield">The metafield</param>
    /// <param name="cancellationToken"></param>
    public Task<BcResultData<BcMetafield>> SendAsync(
        BcId resourceId,
        BcMetafield metafield,
        CancellationToken cancellationToken = default
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
        BcId resourceId,
        IEnumerable<BcMetafield> metafields,
        CancellationToken cancellationToken = default
    )
    {
        var data = new List<BcMetafield>();

        BcRateLimitResponseHeaders rateLimits = null!;

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
            BcId orderId,
            BcMetafield metafield,
            CancellationToken cancellationToken = default
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
            return (true, result, null!);
        }

        var errorResult = new BcResultData<List<T>>
        {
            Success = false,
            Error = result.Error,
            StatusCode = result.StatusCode,
            RateLimits = result.RateLimits,
            ResponseText = result.ResponseText
        };

        return (false, null!, errorResult);
    }
}