namespace Fusionary.BigCommerce.Operations;

public class BcCategoryDelete : BcRequestBuilder
{
    public BcCategoryDelete(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<TProduct>(object categoryId, CancellationToken cancellationToken) =>
        await Api.DeleteAsync(
            BcEndpoint.CategoriesV3(categoryId),
            Filter,
            Options,
            cancellationToken
        );
}