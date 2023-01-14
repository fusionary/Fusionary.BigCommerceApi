namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCustomFieldsGet : BcRequestBuilder,
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
    public BcApiProductCustomFieldsGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcCustomField>> SendAsync(
        BcId productId,
        BcId customFieldId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcCustomField>(productId, customFieldId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        BcId productId,
        BcId customFieldId,
        CancellationToken cancellationToken = default
    ) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.ProductCustomFieldsV3(productId, customFieldId),
            Filter,
            Options,
            cancellationToken
        );
}