namespace Fusionary.BigCommerce.Operations;

public class BcProductsDeleteBulk : BcRequestBuilder,
    IBcDateLastImportedFilter,
    IBcDateModifiedFilter,
    IBcIdRangeFilter,
    IBcProductDeleteFilter
{
    internal BcProductsDeleteBulk(IBcApi api) : base(api)
    { }

    public async Task<bool> SendAsync(CancellationToken cancellationToken) =>
        await Api.DeleteAsync(
            BcEndpoint.ProductsV3(),
            Filter,
            Options,
            cancellationToken
        );
}