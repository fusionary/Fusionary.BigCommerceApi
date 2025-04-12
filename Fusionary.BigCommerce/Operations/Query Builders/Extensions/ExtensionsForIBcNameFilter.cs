namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcNameFilter
{
    /// <summary>
    /// Filter items by name
    /// </summary>
    public static T Name<T>(this T builder, string name, BcModifier modifier = BcModifier.None)
        where T : IBcNameFilter =>
        builder.Add(modifier.Apply("name"), name);
}