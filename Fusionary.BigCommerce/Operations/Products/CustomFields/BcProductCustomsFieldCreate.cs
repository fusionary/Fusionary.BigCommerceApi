namespace Fusionary.BigCommerce.Operations;

public class BcProductCustomsFieldCreate : BcRequestBuilder
{
    public BcProductCustomsFieldCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcCustomField>> SendAsync(
        object productId,
        BcCustomField customField,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcCustomField>(productId, customField, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        object productId,
        object customField,
        CancellationToken cancellationToken
    ) =>
        Api.PostDataAsync<TResponse>(
            BcEndpoint.ProductCustomFieldsV3(productId),
            customField,
            Filter,
            Options,
            cancellationToken
        );
}