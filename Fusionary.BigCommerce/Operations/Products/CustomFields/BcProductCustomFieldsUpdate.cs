namespace Fusionary.BigCommerce.Operations;

public class BcProductCustomFieldsUpdate : BcRequestBuilder
{
    public BcProductCustomFieldsUpdate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcCustomField>> SendAsync(
        int productId,
        BcCustomField customField,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcCustomField>(productId, customField.Id, customField, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        int productId,
        int customFieldId,
        object customField,
        CancellationToken cancellationToken
    ) =>
        Api.PutDataAsync<TResponse>(
            BcEndpoint.ProductCustomFieldsV3(productId, customFieldId),
            customField,
            Filter,
            Options,
            cancellationToken
        );
}