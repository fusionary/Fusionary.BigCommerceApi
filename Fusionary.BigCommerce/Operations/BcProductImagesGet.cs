using Fusionary.BigCommerce.Types;

namespace Fusionary.BigCommerce.Operations;

public record BcProductImagesGet : BcRequestBuilder<BcProductImagesGet>
{
    public BcProductImagesGet(IBigCommerceApi api) : base(api)
    { }

    /// <summary>
    /// Fields to include, in a comma-separated list. The ID and the specified fields will be returned.
    /// </summary>
    public BcProductImagesGet IncludeFields(params string[] values) => Add("include_fields", values);

    /// <summary>
    /// Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be
    /// excluded.
    /// </summary>
    public BcProductImagesGet ExcludeFields(params string[] values) => Add("exclude_fields", values);

    public BcProductImagesGet Page(int page) => Add("page", page);

    public BcProductImagesGet Limit(int limit) => Add("limit", limit);

    public Task<BcDataResponse<BcProductImage>> SendAsync(
        object productId,
        object imageId,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcProductImage>(productId, imageId, cancellationToken);

    public async Task<BcDataResponse<T>> SendAsync<T>(
        object productId,
        object imageId,
        CancellationToken cancellationToken
    ) =>
        await Api.GetAsync<BcDataResponse<T>>(
            BcEndpoint.ProductImagesV3(productId, imageId),
            Filter,
            cancellationToken
        );

    public Task<BcPagedResponse<BcProductImage>> SendAsync(object productId, CancellationToken cancellationToken) =>
        SendAsync<BcProductImage>(productId, cancellationToken);

    public async Task<BcPagedResponse<T>> SendAsync<T>(object productId, CancellationToken cancellationToken) =>
        await Api.GetAsync<BcPagedResponse<T>>(
            BcEndpoint.ProductImagesV3(productId),
            Filter,
            cancellationToken
        );
}