namespace Fusionary.BigCommerce;

public class BcProductGet : BcRequestBuilder<BcProductGet>
{
    public BcProductGet(IBigCommerceApi api) : base(api)
    {
    }
    

    /// <summary>
    /// Sub-resources to include on a product, in a comma-separated list. If options or modifiers is used, results are
    /// limited to 10 per page.
    /// </summary>
    /// <example>
    /// variants, images, custom_fields, bulk_pricing_rules, primary_image, modifiers, options, videos
    /// </example>
    public BcProductGet Include(params string[] values) => Add("include", values);

    /// <summary>
    /// Sub-resources to include on a product, in a comma-separated list. If options or modifiers is used, results are
    /// limited to 10 per page.
    /// </summary>
    public BcProductGet Include(params BcProductInclude[] values) =>
        Include(values.Select(x => x.ToValue()).ToArray());

    /// <summary>
    /// Fields to include, in a comma-separated list. The ID and the specified fields will be returned.
    /// </summary>
    public BcProductGet IncludeFields(params string[] values) => Add("include_fields", values);

    /// <summary>
    /// Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot
    /// be excluded.
    /// </summary>
    public BcProductGet ExcludeFields(params string[] values) => Add("exclude_fields", values);

    public Task<BcDataResponse<BcObject>> SendAsync(int productId, CancellationToken cancellationToken) =>
        SendAsync<BcObject>(productId, cancellationToken);

    public async Task<BcDataResponse<TProduct>> SendAsync<TProduct>(int productId, CancellationToken cancellationToken) =>
        await Api.GetAsync<BcDataResponse<TProduct>>(
            BcEndpoint.ProductsV3(productId),
            Filter,
            cancellationToken
        );
}