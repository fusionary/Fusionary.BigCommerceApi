namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResult> SendAsync(BcId categoryId, CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.CategoryV3(categoryId),
            Filter,
            Options,
            cancellationToken
        );
}