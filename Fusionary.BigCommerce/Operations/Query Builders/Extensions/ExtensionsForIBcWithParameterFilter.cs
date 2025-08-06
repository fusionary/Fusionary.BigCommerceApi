namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcWithParameterFilter
{
    public static T WithQueryStringParameter<T>(this T builder, string name, string value)
        where T : IBcWithParameterFilter => builder.Add(name, value);
}