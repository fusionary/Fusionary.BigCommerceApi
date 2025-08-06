namespace Fusionary.BigCommerce;

public class BigCommerceConfig
{
    public const string DefaultApiHost = "https://api.bigcommerce.com";
    
    public const string DefaultB2BApiHost = "https://api-b2b.bigcommerce.com";

    private string _host = DefaultApiHost;
    
    private string _b2bHost = DefaultB2BApiHost;

    public string Host
    {
        get => string.IsNullOrEmpty(_host) ? DefaultApiHost : _host;
        set => _host = value;
    }

    public string B2BHost
    {
        get => string.IsNullOrEmpty(_b2bHost) ? DefaultB2BApiHost : _b2bHost;
        set => _b2bHost = value;
    }

    public string StoreHash { get; set; } = null!;

    public string AccessToken { get; set; } = null!;
    
    public string B2BAccessToken { get; set; } = null!;

    public string StorefrontUrl { get; set; } = null!;

    public int? StorefrontChannelId { get; set; }

    public string? StorefrontAccessToken { get; set; }
}