namespace Fusionary.BigCommerce.Operations;

public class BcProductCustomFieldsGet : BcRequestBuilder,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
    public BcProductCustomFieldsGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcCustomField>> SendAsync(
        object productId,
        object customFieldId,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcCustomField>(productId, customFieldId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        object productId,
        object customFieldId,
        CancellationToken cancellationToken
    ) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.ProductCustomFieldsV3(productId, customFieldId),
            Filter,
            Options,
            cancellationToken
        );
}