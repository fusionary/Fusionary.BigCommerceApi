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

    /// <summary>
    /// Gets the next page of results from the Pagination meta response of the previous request.
    /// </summary>
    /// <example>
    /// var firstPageResponse = await bcApi.Products.Search().Limit(5).Sort(BcProductSort.Name).SendAsync();
    /// var nextPageResponse = await bcApi.Products.Search().Next(firstPageResponse.Meta.Pagination).SendAsync();
    /// </example>
    public static T Next<T>(this T builder, BcPagination pagination) where T : IBcRequestBuilder
    {
        var next = pagination.Links.Next;

        if (string.IsNullOrWhiteSpace(next))
        {
            throw new BcApiException(
                "Next link not available, expected `pagination.links.next` " +
                "to be a non-empty value similar to `?page=2&limit=50`"
            );
        }

        builder.Filter.Add(new QueryString(next));
        return builder;
    }

    /// <summary>
    /// Gets the previous page of results from the Pagination meta response of the previous request.
    /// </summary>
    /// <example>
    /// var pageResponse = await bcApi.Products.Search().Limit(5).Sort(BcProductSort.Name).Page(3).SendAsync();
    /// var previousPageResponse = await bcApi.Products.Search().Previous(pageResponse.Meta.Pagination).SendAsync();
    /// </example>
    public static T Previous<T>(this T builder, BcPagination pagination) where T : IBcRequestBuilder
    {
        var previous = pagination.Links.Previous;

        if (string.IsNullOrWhiteSpace(previous))
        {
            throw new BcApiException(
                "Previous link not available, expected `pagination.links.previous` " +
                "to be a non-empty value similar to `?page=1&limit=50`"
            );
        }

        builder.Filter.Add(new QueryString(pagination.Links.Previous));
        return builder;
    }

    /// <summary>
    /// Sets the header value for the specified key for this request.
    /// </summary>
    public static T StrictMode<T>(this T builder, bool enabled = true) where T : IBcRequestBuilder
    {
        if (enabled)
        {
            builder.Options.RequestOverrides.Headers[BcHeaderName.XStrictMode] = "true";
        }
        else
        {
            builder.Options.RequestOverrides.Headers.Remove(BcHeaderName.XStrictMode);
        }

        return builder;
    }

    /// <summary>
    /// Conditionally add a request builder step to this request.
    /// </summary>
    public static T When<T>(this T builder, bool condition, Func<T, T> conditionalBuilder)
        where T : IBcRequestBuilder => condition ? conditionalBuilder(builder) : builder;


    /// <summary>
    /// Sets the X-Auth-Token header for this request.
    /// </summary>
    public static T WithAccessToken<T>(this T builder, string accessToken) where T : IBcRequestBuilder =>
        builder.WithHeader(BcHeaderName.XAuthToken, accessToken);

    /// <summary>
    /// Sets the header value for the specified key for this request.
    /// </summary>
    public static T WithHeader<T>(this T builder, string key, string value) where T : IBcRequestBuilder
    {
        builder.Options.RequestOverrides.Headers[key] = value;
        return builder;
    }

    /// <summary>
    /// Applies configured overrides to the request.
    /// </summary>
    public static T WithOverrides<T>(this T builder, BcRequestOverride? requestOverride) where T : IBcRequestBuilder
    {
        if (requestOverride is null)
        {
            return builder;
        }

        if (!string.IsNullOrWhiteSpace(requestOverride.StoreHash))
        {
            builder.Options.RequestOverrides.StoreHash = requestOverride.StoreHash;
        }

        if (requestOverride.HasHeaders)
        {
            foreach (var (key, value) in requestOverride.Headers)
            {
                builder.Options.RequestOverrides.Headers[key] = value;
            }
        }

        return builder;
    }

    /// <summary>
    /// Sets the store hash for the request.
    /// </summary>
    public static T WithStoreHash<T>(this T builder, string storeHash) where T : IBcRequestBuilder
    {
        builder.Options.RequestOverrides.StoreHash = storeHash;
        return builder;
    }
}