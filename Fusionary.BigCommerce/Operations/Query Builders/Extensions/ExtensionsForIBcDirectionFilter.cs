namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcDirectionFilter
{
    /// <summary>
    /// Sort direction.
    /// </summary>
    public static T Direction<T>(this T builder, BcDirection direction)
        where T : IBcDirectionFilter =>
        builder.Add("direction", direction.ToValue());
}