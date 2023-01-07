namespace Fusionary.BigCommerce.Operations;

public class BcProductCustomFieldUpdate : BcRequestBuilder
{
    public BcProductCustomFieldUpdate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcCustomField>> SendAsync(
        object productId,
        object customFieldId,
        BcCustomField customField,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcCustomField, BcCustomField>(productId, customFieldId, customField, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse, TInput>(
        object productId,
        object customFieldId,
        TInput customField,
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