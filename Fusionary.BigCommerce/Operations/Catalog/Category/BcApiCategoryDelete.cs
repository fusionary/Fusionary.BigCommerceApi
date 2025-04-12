namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryDelete : BcRequestBuilder, IBcApiOperation
{
    public BcApiCategoryDelete(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync(BcId categoryId, CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.CategoryV3(categoryId),
            Filter,
            Options,
            cancellationToken
        );
}