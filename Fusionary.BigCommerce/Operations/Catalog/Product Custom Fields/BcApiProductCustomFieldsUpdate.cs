namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCustomFieldsUpdate : BcRequestBuilder, IBcApiOperation
{
    public BcApiProductCustomFieldsUpdate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcCustomField>> SendAsync(
        BcId productId,
        BcCustomField customField,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcCustomField>(productId, customField.Id, customField, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        BcId productId,
        BcId customFieldId,
        object customField,
        CancellationToken cancellationToken = default
    ) =>
        Api.PutDataAsync<TResponse>(
            BcEndpoint.ProductCustomFieldsV3(productId, customFieldId),
            customField,
            Filter,
            Options,
            cancellationToken
        );
}