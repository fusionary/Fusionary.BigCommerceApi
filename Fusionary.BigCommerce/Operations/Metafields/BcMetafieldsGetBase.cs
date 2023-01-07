namespace Fusionary.BigCommerce.Operations;

public abstract class BcMetafieldsGetBase : BcRequestBuilder,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
    protected BcMetafieldsGetBase(IBcApi api) : base(api)
    { }

    /// <summary>
    /// Gets the resource path for the request.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="metafieldId">The metafield id</param>
    protected abstract string MetafieldResourceEndpoint(object resourceId, object metafieldId);

    /// <summary>
    /// Gets a metafield for the specified resource.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="metafieldId">The metafield id</param>
    /// <param name="cancellationToken"></param>
    public Task<BcResultData<BcMetafield>> SendAsync(
        int resourceId,
        object metafieldId,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcMetafield>(resourceId, metafieldId, cancellationToken);

    /// <summary>
    /// Gets a metafield for the specified resource.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="metafieldId">The metafield id</param>
    /// <param name="cancellationToken"></param>
    public async Task<BcResultData<T>> SendAsync<T>(
        int resourceId,
        object metafieldId,
        CancellationToken cancellationToken
    ) =>
        await Api.GetDataAsync<T>(
            MetafieldResourceEndpoint(resourceId, metafieldId),
            Filter,
            Options,
            cancellationToken
        );

    public Task<BcResultData<List<BcMetafield>>> SendAsync(
        int resourceId,
        IEnumerable<object> metafieldIds,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcMetafield>(resourceId, metafieldIds, cancellationToken);

    /// <summary>
    /// Gets the specified metafields for the specified resource.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="metafieldIds">The metafield ids</param>
    /// <param name="cancellationToken"></param>
    public async Task<BcResultData<List<T>>> SendAsync<T>(
        int resourceId,
        IEnumerable<object> metafieldIds,
        CancellationToken cancellationToken
    )
    {
        var data = new List<T>();

        BcRateLimitResponseHeaders rateLimits = default!;

        foreach (var metafieldId in metafieldIds)
        {
            var (success, result, errorResult) = await SendItemAsync<T>(resourceId, metafieldId, cancellationToken);

            if (!success)
            {
                return errorResult;
            }

            data.Add(result.Data);
            rateLimits = result.RateLimits;
        }

        return new BcResultData<List<T>>
        {
            Success = true, StatusCode = HttpStatusCode.OK, Data = data, RateLimits = rateLimits
        };
    }

    private async Task<(bool success, BcResultData<T> data, BcResultData<List<T>> errorResult)>
        SendItemAsync<T>(
            object orderId,
            object metafieldId,
            CancellationToken cancellationToken
        )
    {
        var result = await Api.GetDataAsync<T>(
            MetafieldResourceEndpoint(orderId, metafieldId),
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