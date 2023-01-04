namespace Fusionary.BigCommerce.Operations;

public record BcProductImagesGet : BcRequestBuilder<BcProductImagesGet>,
    IBcPageableFilter,
    IBcExcludeFieldsFilter,
    IBcIncludeFieldsFilter
{
    public BcProductImagesGet(IBigCommerceApi api) : base(api)
    { }

    public Task<BcDataResult<BcProductImage>> SendAsync(
        object productId,
        object imageId,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcProductImage>(productId, imageId, cancellationToken);

    public async Task<BcDataResult<T>> SendAsync<T>(
        object productId,
        object imageId,
        CancellationToken cancellationToken
    ) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.ProductImagesV3(productId, imageId),
            Filter,
            cancellationToken
        );

    public Task<BcPagedResult<BcProductImage>> SendAsync(object productId, CancellationToken cancellationToken) =>
        SendAsync<BcProductImage>(productId, cancellationToken);

    public async Task<BcPagedResult<T>> SendAsync<T>(object productId, CancellationToken cancellationToken) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.ProductImagesV3(productId),
            Filter,
            cancellationToken
        );
}