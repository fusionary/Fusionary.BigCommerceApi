namespace Fusionary.BigCommerce.Operations;

public abstract class BcMetafieldsGetAllBase : BcRequestBuilder,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcPageableFilter,
    IBcDirectionFilter,
    IBcMetafieldGetAllFilter
{
    protected BcMetafieldsGetAllBase(IBcApi api) : base(api)
    { }

    /// <summary>
    /// Gets the resource path for the request.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    protected abstract string MetafieldResourceEndpoint(BcId resourceId);

    /// <summary>
    /// Gets a list of metafields for the specified resource.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="cancellationToken"></param>
    public Task<BcResultPaged<BcMetafield>> SendAsync(BcId resourceId, CancellationToken cancellationToken = default) =>
        SendAsync<BcMetafield>(resourceId, cancellationToken);

    /// <summary>
    /// Gets a list of metafields for the specified resource.
    /// </summary>
    /// <param name="resourceId">The resource id (productId, orderId, brandId, etc...)</param>
    /// <param name="cancellationToken"></param>
    public async Task<BcResultPaged<T>> SendAsync<T>(BcId resourceId, CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            MetafieldResourceEndpoint(resourceId),
            Filter,
            Options,
            cancellationToken
        );
}