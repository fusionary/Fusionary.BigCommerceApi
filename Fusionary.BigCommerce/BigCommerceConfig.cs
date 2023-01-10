namespace Fusionary.BigCommerce;

public class BigCommerceConfig
{
    public const string DefaultApiHost = "https://api.bigcommerce.com";

    private string _host = DefaultApiHost;

    public string Host
    {
        get => string.IsNullOrEmpty(_host) ? DefaultApiHost : _host;
        set => _host = value;
    }

    public string StoreHash { get; set; } = null!;

    public string AccessToken { get; set; } = null!;

    public string StorefrontUrl { get; set; } = null!;

    public int? StorefrontChannelId { get; set; }

    public string? StorefrontAccessToken { get; set; }
}