namespace Fusionary.BigCommerce.Operations;

public abstract record BcRequestBuilder<T> where T : BcRequestBuilder<T>
{
    protected BcRequestBuilder(IBigCommerceApi api)
    {
        Api = api;
        Filter = BcFilter.Create();
    }

    protected IBigCommerceApi Api { get; }

    protected BcFilter Filter { get; }

    private T This => (T)this;

    public T Add(string key, IEnumerable<int> values)
    {
        Filter.Add(key, values);
        return This;
    }

    public T Add(string key, IEnumerable<string> values)
    {
        Filter.Add(key, values);
        return This;
    }

    public T Add(string key, IEnumerable<object> values)
    {
        Filter.Add(key, values);
        return This;
    }

    public T Add(string key, string value)
    {
        Filter.Add(key, value);
        return This;
    }

    public T Add(string key, BcDateTime value)
    {
        Filter.Add(key, value);
        return This;
    }

    public T Add(string key, BcDate value)
    {
        Filter.Add(key, value);
        return This;
    }

    public T Add(string key, decimal value)
    {
        Filter.Add(key, value);
        return This;
    }

    public T Add(string key, double value)
    {
        Filter.Add(key, value);
        return This;
    }

    public T Add(string key, int value)
    {
        Filter.Add(key, value);
        return This;
    }

    public T Add(string key, bool value)
    {
        Filter.Add(key, value);
        return This;
    }

    public T Add(string key, object value)
    {
        Filter.Add(key, value);
        return This;
    }

    public T Add(QueryString queryString)
    {
        Filter.Add(queryString);
        return This;
    }

    public T ConfigureClient(Action<HttpClient> configureClient)
    {
        configureClient(Api.BigCommerceHttp.Client);
        return This;
    }

    public T When(bool condition, Func<T, T> builder) => condition ? builder(This) : This;

    public T WithAccessToken(string accessToken) =>
        ConfigureClient(
            httpClient =>
            {
                var requestHeaders = httpClient.DefaultRequestHeaders;

                requestHeaders.Remove("X-Auth-Client");
                requestHeaders.TryAddWithoutValidation("X-Auth-Client", accessToken);
            }
        );

    public T WithOverrides(BcRequestOverride? requestOverride)
    {
        if (!string.IsNullOrEmpty(requestOverride?.AccessToken))
        {
            WithAccessToken(requestOverride.AccessToken);
        }

        if (!string.IsNullOrEmpty(requestOverride?.StoreHash))
        {
            WithStoreHash(requestOverride.StoreHash);
        }

        return This;
    }

    public T WithStoreHash(string storeHash) => ConfigureClient(
        httpClient =>
        {
            httpClient.BaseAddress = new UriBuilder(httpClient.BaseAddress!) { Path = $"/stores/{storeHash}/" }.Uri;
        }
    );
}