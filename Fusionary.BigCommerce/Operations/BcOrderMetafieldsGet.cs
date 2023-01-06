namespace Fusionary.BigCommerce.Operations;

public record BcOrderMetafieldsGet : BcRequestBuilder<BcOrderMetafieldsGet>,
    IBcPageableFilter,
    IBcDirectionFilter
{
    public BcOrderMetafieldsGet(IBigCommerceApi api) : base(api)
    { }

    public Task<BcPagedResult<BcMetafield>> SendAsync(int orderId, CancellationToken cancellationToken) =>
        SendAsync<BcMetafield>(orderId, cancellationToken);

    public async Task<BcPagedResult<T>> SendAsync<T>(int orderId, CancellationToken cancellationToken) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.OrderMetafieldsV3(orderId),
            Filter,
            cancellationToken
        );

    #region Filters

    /// <summary>
    /// Filter based on a metafield's key.
    /// </summary>
    public BcOrderMetafieldsGet Key(string value) => Add("key", value);

    /// <summary>
    /// Filter based on a metafield's namespace.
    /// </summary>
    public BcOrderMetafieldsGet Namespace(string value) => Add("namespace", value);

    #endregion
}