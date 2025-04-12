namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTreesUpsert(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResultData<BcCategoryTree[]>> SendAsync(
        IEnumerable<BcCategoryTreeUpsert> input,
        CancellationToken cancellationToken = default
    ) =>
        await Api.PutDataAsync<BcCategoryTree[]>(
            BcEndpoint.CategoryTreesV3(),
            input,
            Filter,
            Options,
            cancellationToken
        );
}