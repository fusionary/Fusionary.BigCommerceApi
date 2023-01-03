namespace Fusionary.BigCommerce.Operations;

public record BcFilter
{
    private QueryString _queryString;

    private BcFilter(QueryString queryString)
    {
        _queryString = queryString;
    }

    public static BcFilter Create(QueryString queryString = default) => new(queryString);

    public static implicit operator QueryString(BcFilter filter) => filter._queryString;

    public BcFilter Add(string key, params object[] values) => Add(key, string.Join(",", values));

    public BcFilter Add(string key, params int[] values) => Add(key, string.Join(",", values));

    public BcFilter Add(string key, params string[] values) => Add(key, string.Join(",", values));

    public BcFilter Add(string key, bool value) => Add(key, value ? "true" : "false");

    public BcFilter Add(string key, object value) => Add(key, $"{value}");

    public BcFilter Add(string key, DateOnly value) => Add(key, $"{value:yyyy-MM-dd}");

    public BcFilter Add(string key, int value) => Add(key, $"{value}");

    public BcFilter Add(string key, double value) => Add(key, $"{value}");

    public BcFilter Add(string key, decimal value) => Add(key, $"{value}");

    public BcFilter Add(QueryString queryString)
    {
        _queryString = _queryString.Add(queryString);
        return this;
    }
    
    public BcFilter Add(string key, string value)
    {
        _queryString = _queryString.Add(key, value);
        return this;
    }
}