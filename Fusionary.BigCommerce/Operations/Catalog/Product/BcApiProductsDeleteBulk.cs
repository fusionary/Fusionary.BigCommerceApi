namespace Fusionary.BigCommerce.Operations;

public class BcApiProductsDeleteBulk : BcRequestBuilder,
    IBcApiOperation,
    IBcDateLastImportedFilter,
    IBcDateModifiedFilter,
    IBcIdRangeFilter,
    IBcProductDeleteFilter
{
    internal BcApiProductsDeleteBulk(IBcApi api) : base(api)
    { }

    public async Task<bool> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.ProductsV3(),
            Filter,
            Options,
            cancellationToken
        );
}