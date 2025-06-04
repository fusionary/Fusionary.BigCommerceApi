namespace Fusionary.BigCommerce.Operations.BatchMetafields;

public class BcApiBrandBatchMetafieldsGetAll(IBcApi api) : BcRequestBuilder(api),
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcPageableFilter,
    IBcDirectionFilter,
    IBcMetafieldGetAllFilter
{
    /// <summary>
    /// Gets a list of metafields for the specified resource.
    /// </summary>
    /// <param name="cancellationToken"></param>
    public async Task<BcResultPaged<T>> SendAsync<T>(CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.BrandMetafieldsV3(),
            Filter,
            Options,
            cancellationToken
        );
}