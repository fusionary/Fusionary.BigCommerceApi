namespace Fusionary.BigCommerce.Operations;

public class BcApiProductsDeleteBulk(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcDateLastImportedFilter,
    IBcDateModifiedFilter,
    IBcIdRangeFilter,
    IBcProductDeleteFilter
{
    public async Task<bool> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.ProductsV3(),
            Filter,
            Options,
            cancellationToken
        );
}