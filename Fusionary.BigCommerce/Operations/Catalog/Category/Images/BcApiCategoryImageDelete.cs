namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryImageDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResult> SendAsync(BcId categoryId, CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.CategoryImagesV3(categoryId),
            Filter,
            Options,
            cancellationToken
        );
}