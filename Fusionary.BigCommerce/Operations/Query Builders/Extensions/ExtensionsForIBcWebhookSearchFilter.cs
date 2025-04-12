namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcWebhookSearchFilter
{
    public static T Destination<T>(this T builder, string destination)
        where T : IBcWebhookSearchFilter
        => builder.Add("destination", destination);

    public static T Scope<T>(this T builder, string scope)
        where T : IBcWebhookSearchFilter
        => builder.Add("scope", scope);
}