namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandsDeleteBulk : BcRequestBuilder, IBcApiOperation,
    IBcNameFilter,
    IBcPageTitleFilter
{
    public BcApiBrandsDeleteBulk(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<TProduct>(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.BrandsV3(),
            Filter,
            Options,
            cancellationToken
        );
}