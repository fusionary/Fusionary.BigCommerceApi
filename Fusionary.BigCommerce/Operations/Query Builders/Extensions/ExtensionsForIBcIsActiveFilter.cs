namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcIsActiveFilter
{
    /// <summary>
    /// Filter items by is_active flag.
    /// </summary>
    public static T IsActive<T>(this T builder, bool isActive)
        where T : IBcIsActiveFilter =>
        builder.Add("is_active", isActive);
}