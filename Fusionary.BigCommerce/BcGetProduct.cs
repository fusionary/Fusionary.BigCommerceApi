using Microsoft.AspNetCore.Http;

namespace Fusionary.BigCommerce;

public class BcGetProduct : BcRequestBuilder<BcGetProduct>
{
    public BcGetProduct(IBigCommerceApi api, int id, QueryString queryString) : base(api, queryString)
    {
        Id = id;
    }

    private int Id { get; }

    /// <summary>
    /// Sub-resources to include on a product, in a comma-separated list. If options or modifiers is used, results are
    /// limited to 10 per page.
    /// </summary>
    /// <example>
    /// variants, images, custom_fields, bulk_pricing_rules, primary_image, modifiers, options, videos
    /// </example>
    public BcGetProduct Include(params string[] values) => Add(BcProductFilter.Include, values);

    /// <summary>
    /// Sub-resources to include on a product, in a comma-separated list. If options or modifiers is used, results are
    /// limited to 10 per page.
    /// </summary>
    public BcGetProduct Include(params BcProductInclude[] values) =>
        Include(values.Select(x => x.ToValue()).ToArray());

    /// <summary>
    /// Fields to include, in a comma-separated list. The ID and the specified fields will be returned.
    /// </summary>
    public BcGetProduct IncludeFields(params string[] values) => Add(BcProductFilter.IncludeFields, values);

    /// <summary>
    /// Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot
    /// be excluded.
    /// </summary>
    public BcGetProduct ExcludeFields(params string[] values) => Add(BcProductFilter.ExcludeFields, values);

    public Task<BcResponse<BcObject>> SendAsync(CancellationToken cancellationToken) =>
        SendAsync<BcObject>(cancellationToken);

    public async Task<BcResponse<TProduct>> SendAsync<TProduct>(CancellationToken cancellationToken) =>
        await Api.GetAsync<BcResponse<TProduct>>(
            BcEndpoint.ProductsV3(Id),
            Filter,
            cancellationToken
        );
}