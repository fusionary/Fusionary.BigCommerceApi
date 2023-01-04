namespace Fusionary.BigCommerce.Operations;

public record BcCategoriesSearch : BcRequestBuilder<BcCategoriesSearch>,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcPageableFilter
{
    internal BcCategoriesSearch(IBigCommerceApi api) : base(api)
    { }

    /// <summary>
    /// Filter items by id.
    /// </summary>
    public BcCategoriesSearch Id(int id) => Add("id", id);

    /// <summary>
    /// Filter items by ids.
    /// </summary>
    public BcCategoriesSearch Id(BcModifier modifier, params int[] id) => Add(modifier.Apply("id"), id);

    /// <summary>
    /// Filter items based on whether the product is currently visible on the storefront.
    /// </summary>
    public BcCategoriesSearch IsVisible(bool isVisible) => Add("is_visible", isVisible);

    /// <summary>
    /// Filter items by keywords found in the name or sku fields
    /// </summary>
    public BcCategoriesSearch Keyword(string keyword) => Add("keyword", keyword);

    /// <summary>
    /// Filter items by name.
    /// </summary>
    public BcCategoriesSearch Name(params string[] names) => Add(names.Length > 1 ? "name:like" : "name", names);

    /// <summary>
    /// Filter items by name.
    /// </summary>
    public BcCategoriesSearch PageTitle(params string[] pageTiles) => Add(
        pageTiles.Length > 1 ? "page_title:like" : "page_title",
        pageTiles
    );

    /// <summary>
    /// Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.
    /// </summary>
    public BcCategoriesSearch ParentId(int parentId) => Add("parent_id", parentId);

    /// <summary>
    /// Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.
    /// </summary>
    public BcCategoriesSearch ParentId(BcModifier modifier, params int[] parentIds) =>
        Add(modifier.Apply("parent_id"), parentIds);

    public Task<BcPagedResult<BcCategory>> SendAsync(CancellationToken cancellationToken) =>
        SendAsync<BcCategory>(cancellationToken);

    public async Task<BcPagedResult<T>> SendAsync<T>(CancellationToken cancellationToken) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.CategoriesV3(),
            Filter,
            cancellationToken
        );
}