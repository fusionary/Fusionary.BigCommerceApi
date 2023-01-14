namespace Fusionary.BigCommerce.Operations;

public class BcApiProductImagesGet : BcRequestBuilder,
    IBcApiOperation,
    IBcPageableFilter,
    IBcExcludeFieldsFilter,
    IBcIncludeFieldsFilter
{
    public BcApiProductImagesGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductImage>> SendAsync(
        BcId productId,
        BcId imageId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductImage>(productId, imageId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        BcId productId,
        BcId imageId,
        CancellationToken cancellationToken = default
    ) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.ProductImagesV3(productId, imageId),
            Filter,
            Options,
            cancellationToken
        );

    public Task<BcResultPaged<BcProductImage>> SendAsync(
        BcId productId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductImage>(productId, cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(BcId productId, CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.ProductImagesV3(productId),
            Filter,
            Options,
            cancellationToken
        );
}