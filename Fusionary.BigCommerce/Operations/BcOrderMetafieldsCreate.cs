namespace Fusionary.BigCommerce.Operations;

public record BcOrderMetafieldsCreate : BcRequestBuilder<BcOrderMetafieldsCreate>
{
    public BcOrderMetafieldsCreate(IBigCommerceApi api) : base(api)
    { }

    public Task<BcDataResult<BcMetafield>> SendAsync(
        object orderId,
        BcMetafieldPost metafield,
        CancellationToken cancellationToken
    ) => Api.PostDataAsync<BcMetafield>(
        BcEndpoint.OrdersMetafieldsV3(orderId),
        metafield,
        Filter,
        cancellationToken
    );

    public async Task<BcPagedResult<BcMetafield>> SendAsync(
        object orderId,
        BcPermissionSet permissionSet,
        string metafieldNamespace,
        IEnumerable<BcMetafieldItem> metafields,
        CancellationToken cancellationToken
    )
    {
        foreach (var metafield in metafields)
        {
            var result = await Api.PostDataAsync<BcMetafield>(
                BcEndpoint.OrdersMetafieldsV3(orderId),
                metafield.ToMetafieldPost(permissionSet, metafieldNamespace),
                cancellationToken
            );

            if (!result.Success)
            {
                return new BcPagedResult<BcMetafield>
                {
                    Success = false, Error = result.Error, ResponseText = result.ResponseText
                };
            }
        }

        return await Api.GetPagedAsync<BcMetafield>(
            BcEndpoint.OrdersMetafieldsV3(orderId),
            QueryString.Create("namespace", metafieldNamespace),
            cancellationToken
        );
    }
}