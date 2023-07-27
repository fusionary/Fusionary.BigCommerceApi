namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTreesUpsert : BcRequestBuilder,
    IBcApiOperation
{
    public BcApiCategoryTreesUpsert(IBcApi api) : base(api)
    { }

    public async Task<BcResultData<BcCategoryTree[]>> SendAsync<T>(IEnumerable<BcCategoryTreeUpsert> input, CancellationToken cancellationToken = default) =>
        await Api.PutDataAsync<BcCategoryTree[]>(
            BcEndpoint.CategoryTreesV3(),
            input,
            Filter,
            Options,
            cancellationToken
        );
}
