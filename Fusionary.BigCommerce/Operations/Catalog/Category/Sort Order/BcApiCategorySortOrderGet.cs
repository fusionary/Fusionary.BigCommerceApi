namespace Fusionary.BigCommerce.Operations;

public class BcApiCategorySortOrderGet(IBcApi api) : BcRequestBuilder(api), IBcApiOperation, IBcPageableFilter
{
    public async Task<BcResultPaged<BcCategorySortOrder>> SendAsync(
        BcId categoryId,
        CancellationToken cancellationToken = default
    ) =>
        await Api.GetPagedAsync<BcCategorySortOrder>(
            BcEndpoint.CategorySortOrderV3(categoryId),
            Filter,
            Options,
            cancellationToken
        );
}