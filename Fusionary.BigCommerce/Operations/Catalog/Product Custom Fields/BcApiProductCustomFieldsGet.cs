namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCustomFieldsGet(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
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