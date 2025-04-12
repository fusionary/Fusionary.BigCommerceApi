namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcIdFilter
{
    /// <summary>
    /// Filter items by id.
    /// </summary>
    public static T Id<T>(this T builder, BcId id)
        where T : IBcIdFilter =>
        builder.Add("id", id.Value);
}