namespace Fusionary.BigCommerce.Operations;

public class BcBrandDeleteBulk : BcRequestBuilder,
    IBcNameFilter,
    IBcPageTitleFilter
{
    public BcBrandDeleteBulk(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<TProduct>(CancellationToken cancellationToken) =>
        await Api.DeleteAsync(
            BcEndpoint.BrandsV3(),
            Filter,
            Options,
            cancellationToken
        );
}