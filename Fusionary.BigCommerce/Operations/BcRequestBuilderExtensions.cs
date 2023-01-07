namespace Fusionary.BigCommerce.Operations;

public static class BcRequestBuilderExtensions
{
    public static T Add<T>(this T builder, string key, IEnumerable<int> values) where T : IBcRequestBuilder
    {
        builder.Filter.Add(key, values);
        return builder;
    }

    public static T Add<T>(this T builder, string key, IEnumerable<string> values) where T : IBcRequestBuilder
    {
        builder.Filter.Add(key, values);
        return builder;
    }

    public static T Add<T>(this T builder, string key, IEnumerable<object> values) where T : IBcRequestBuilder
    {
        builder.Filter.Add(key, values);
        return builder;
    }

    public static T Add<T>(this T builder, string key, string value) where T : IBcRequestBuilder
    {
        builder.Filter.Add(key, value);
        return builder;
    }

    public static T Add<T>(this T builder, string key, BcDateTime value) where T : IBcRequestBuilder
    {
        builder.Filter.Add(key, value);
        return builder;
    }

    public static T Add<T>(this T builder, string key, BcDate value) where T : IBcRequestBuilder
    {
        builder.Filter.Add(key, value);
        return builder;
    }

    public static T Add<T>(this T builder, string key, decimal value) where T : IBcRequestBuilder
    {
        builder.Filter.Add(key, value);
        return builder;
    }

    public static T Add<T>(this T builder, string key, double value) where T : IBcRequestBuilder
    {
        builder.Filter.Add(key, value);
        return builder;
    }

    public static T Add<T>(this T builder, string key, int value) where T : IBcRequestBuilder
    {
        builder.Filter.Add(key, value);
        return builder;
    }

    public static T Add<T>(this T builder, string key, bool value) where T : IBcRequestBuilder
    {
        builder.Filter.Add(key, value);
        return builder;
    }

    public static T Add<T>(this T builder, string key, object value) where T : IBcRequestBuilder
    {
        builder.Filter.Add(key, value);
        return builder;
    }

    public static T Add<T>(this T builder, QueryString queryString) where T : IBcRequestBuilder
    {
        builder.Filter.Add(queryString);
        return builder;
    }

    public static T When<T>(this T builder, bool condition, Func<T, T> conditionalBuilder)
        where T : IBcRequestBuilder => condition ? conditionalBuilder(builder) : builder;

    public static T WithAccessToken<T>(this T builder, string accessToken) where T : IBcRequestBuilder
    {
        builder.Options.RequestOverrides.AccessToken = accessToken;
        return builder;
    }

    public static T WithOverrides<T>(this T builder, BcRequestOverride? requestOverride) where T : IBcRequestBuilder
    {
        if (!string.IsNullOrEmpty(requestOverride?.AccessToken))
        {
            builder.WithAccessToken(requestOverride.AccessToken);
        }

        if (!string.IsNullOrEmpty(requestOverride?.StoreHash))
        {
            builder.WithStoreHash(requestOverride.StoreHash);
        }

        return builder;
    }

    public static T WithStoreHash<T>(this T builder, string storeHash) where T : IBcRequestBuilder
    {
        builder.Options.RequestOverrides.StoreHash = storeHash;
        return builder;
    }
}