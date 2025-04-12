namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcSkuFilter
{
    /// <summary>
    /// Filter items by sku
    /// </summary>
    public static T Sku<T>(this T builder, string sku, BcModifier modifier = BcModifier.None)
        where T : IBcSkuFilter =>
        builder.Add(modifier.Apply("sku"), sku);
}