namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCustomsFieldCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcCustomField>> SendAsync(
        BcId productId,
        BcCustomField customField,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcCustomField>(productId, customField, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        BcId productId,
        object customField,
        CancellationToken cancellationToken = default
    ) =>
        Api.PostDataAsync<TResponse>(
            BcEndpoint.ProductCustomFieldsV3(productId),
            customField,
            Filter,
            Options,
            cancellationToken
        );
}