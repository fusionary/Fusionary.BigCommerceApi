namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcPageTitleFilter
{
    /// <summary>
    /// Filter items by page_title
    /// </summary>
    public static T PageTitle<T>(this T builder, string pageTitle, BcModifier modifier = BcModifier.None)
        where T : IBcPageTitleFilter =>
        builder.Add(modifier.Apply("page_title"), pageTitle);
}