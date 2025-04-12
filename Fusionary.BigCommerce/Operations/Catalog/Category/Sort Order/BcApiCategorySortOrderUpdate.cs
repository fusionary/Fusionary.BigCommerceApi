namespace Fusionary.BigCommerce.Operations;

public class BcApiCategorySortOrderUpdate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation, IBcPageableFilter
{
    public async Task<BcResultPaged<BcCategorySortOrder>> SendAsync(
        BcId categoryId,
        IEnumerable<BcCategorySortOrder> data,
        CancellationToken cancellationToken = default
    )
    {
        var result = await Api.PutAsync<List<BcCategorySortOrder>, BcMetadataPagination>(
            BcEndpoint.CategorySortOrderV3(categoryId),
            data,
            Filter,
            Options,
            cancellationToken
        );

        return result.AsPagedResult();
    }
}