namespace Fusionary.BigCommerce.Operations;

public abstract class BcMetafieldDeleteBase : BcRequestBuilder
{
    protected BcMetafieldDeleteBase(IBcApi api) : base(api)
    { }

    /// <summary>
    /// Gets the resource path for the request.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="metafieldId">The metafield id</param>
    protected abstract string MetafieldResourceEndpoint(object resourceId, object metafieldId);

    /// <summary>
    /// Deletes a metafield from a resource.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="metafieldId">The metafield id</param>
    /// <param name="cancellationToken"></param>
    public Task<BcResult> SendAsync(object resourceId, object metafieldId, CancellationToken cancellationToken) =>
        Api.DeleteAsync(MetafieldResourceEndpoint(resourceId, metafieldId), Filter, Options, cancellationToken);

    /// <summary>
    /// Deletes metafields from a resource.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, etc...)</param>
    /// <param name="metafieldIds">The metafield ids to delete</param>
    /// <param name="cancellationToken"></param>
    public async Task<BcResult> SendAsync(
        object resourceId,
        IEnumerable<object> metafieldIds,
        CancellationToken cancellationToken
    )
    {
        foreach (var metafieldId in metafieldIds)
        {
            var result = await Api.DeleteAsync(
                MetafieldResourceEndpoint(resourceId, metafieldId),
                Filter,
                Options,
                cancellationToken
            );

            if (!result.Success)
            {
                return result;
            }
        }

        return new BcResult
        {
            Success = true, StatusCode = HttpStatusCode.NoContent, ResponseText = "Metafields deleted"
        };
    }
}