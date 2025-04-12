namespace Fusionary.BigCommerce.Operations;

public class BcApiProductVariantsCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcProductVariant>> SendAsync(
        BcProductVariantPost variant,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductVariant>(variant.ProductId, variant, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        int productId,
        object variant,
        CancellationToken cancellationToken = default
    ) =>
        Api.PostDataAsync<TResponse>(
            BcEndpoint.ProductVariantsV3(productId),
            variant,
            Filter,
            Options,
            cancellationToken
        );
}