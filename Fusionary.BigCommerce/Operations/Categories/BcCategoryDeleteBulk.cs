namespace Fusionary.BigCommerce.Operations;

public class BcCategoryDeleteBulk : BcRequestBuilder,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcCategoryFilter
{
    public BcCategoryDeleteBulk(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<TProduct>(CancellationToken cancellationToken) =>
        await Api.DeleteAsync(
            BcEndpoint.CategoriesV3(),
            Filter,
            Options,
            cancellationToken
        );
}