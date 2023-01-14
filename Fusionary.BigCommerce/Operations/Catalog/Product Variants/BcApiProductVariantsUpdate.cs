namespace Fusionary.BigCommerce.Operations;

public class BcApiProductVariantsUpdate : BcRequestBuilder, IBcApiOperation
{
    public BcApiProductVariantsUpdate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductVariant>> SendAsync(
        BcProductVariantPut variant,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductVariant>(variant.ProductId, variant.Id, variant, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        BcId productId,
        BcId variantId,
        object variant,
        CancellationToken cancellationToken = default
    ) =>
        Api.PutDataAsync<TResponse>(
            BcEndpoint.ProductVariantsV3(productId, variantId),
            variant,
            Filter,
            Options,
            cancellationToken
        );
}