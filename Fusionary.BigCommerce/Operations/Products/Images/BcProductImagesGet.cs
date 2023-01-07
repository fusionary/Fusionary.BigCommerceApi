namespace Fusionary.BigCommerce.Operations;

public class BcProductImagesGet : BcRequestBuilder,
    IBcPageableFilter,
    IBcExcludeFieldsFilter,
    IBcIncludeFieldsFilter
{
    public BcProductImagesGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductImage>> SendAsync(
        object productId,
        object imageId,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcProductImage>(productId, imageId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        object productId,
        object imageId,
        CancellationToken cancellationToken
    ) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.ProductImagesV3(productId, imageId),
            Filter,
            Options,
            cancellationToken
        );

    public Task<BcResultPaged<BcProductImage>> SendAsync(object productId, CancellationToken cancellationToken) =>
        SendAsync<BcProductImage>(productId, cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(object productId, CancellationToken cancellationToken) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.ProductImagesV3(productId),
            Filter,
            Options,
            cancellationToken
        );
}