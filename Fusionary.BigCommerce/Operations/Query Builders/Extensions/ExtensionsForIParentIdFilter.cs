namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIParentIdFilter
{
    /// <summary>
    /// Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.
    /// </summary>
    public static T ParentId<T>(this T builder, BcId parentId)
        where T : IParentIdFilter =>
        builder.Add("parent_id", parentId.Value);

    /// <summary>
    /// Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.
    /// </summary>
    public static T ParentId<T>(this T builder, IEnumerable<BcId> parentIds, BcModifier modifier)
        where T : IParentIdFilter =>
        builder.Add(modifier.Apply("parent_id"), parentIds.Select(x => x.Value));
}