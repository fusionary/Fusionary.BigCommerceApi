namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcCategoryTreeFilter
{
    /// <summary>
    /// Filter items by category_uuid.
    /// </summary>
    public static T CategoryUuid<T>(this T builder, IEnumerable<BcId> parentIds, BcModifier modifier)
        where T : IBcCategoryTreeFilter =>
        builder.Add(modifier.Apply("category_uuid"), parentIds.Select(x => x.Value));

    /// <summary>
    /// Filter items by tree_id.
    /// </summary>
    public static T TreeId<T>(this T builder, IEnumerable<BcId> parentIds, BcModifier modifier)
        where T : IBcCategoryTreeFilter =>
        builder.Add(modifier.Apply("tree_id"), parentIds.Select(x => x.Value));
}