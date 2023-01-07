namespace Fusionary.BigCommerce.Operations;

public class BcProductDeleteBulk : BcRequestBuilder,
    IBcDateLastImportedFilter,
    IBcDateModifiedFilter,
    IBcIdRangeFilter,
    IBcProductDeleteFilter
{
    internal BcProductDeleteBulk(IBcApi api) : base(api)
    { }

    public async Task<bool> SendAsync(CancellationToken cancellationToken) =>
        await Api.DeleteAsync(
            BcEndpoint.ProductsV3(),
            Filter,
            Options,
            cancellationToken
        );
}