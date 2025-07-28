namespace Fusionary.BigCommerce.Operations;

public class BcApiProductVariantsUpdateBatch(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultPaged<BcProductVariant>> SendAsync(
        IEnumerable<BcVariantBatchPut> variants,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductVariant>(variants, cancellationToken);
    
    /// <summary>
    /// Updates a batch of variant objects.
    /// <para>
    /// <b>Currently, the limit is 50 variants. However, this is subject to change.</b>
    /// </para>
    /// </summary>
    public async Task<BcResultPaged<TResponse>> SendAsync<TResponse>(
        IEnumerable<object> variants,
        CancellationToken cancellationToken = default
    )
    {
        var data = await Api.SendRequestAsync<List<TResponse>, BcMetadataPagination>(
            HttpMethod.Put,
            BcEndpoint.ProductVariantsV3(),
            variants,
            Filter,
            Options,
            cancellationToken
        );

        return data.AsPagedResult();
    }
}