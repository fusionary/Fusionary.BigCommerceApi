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

    public T Add(string key, params object[] values)
    {
        Filter.Add(key, values);
        return This;
    }

    public T Add(string key, params int[] values)
    {
        Filter.Add(key, values);
        return This;
    }

    public T Add(string key, params string[] values)
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

    public T When(bool condition, Func<T, T> builder) => condition ? builder(This) : This;
}