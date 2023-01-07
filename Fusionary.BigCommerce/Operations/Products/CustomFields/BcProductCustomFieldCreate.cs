namespace Fusionary.BigCommerce.Operations;

public class BcProductCustomFieldCreate : BcRequestBuilder
{
    public BcProductCustomFieldCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcCustomField>> SendAsync(
        object productId,
        BcCustomField customField,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcCustomField, BcCustomField>(productId, customField, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse, TInput>(
        object productId,
        TInput customField,
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