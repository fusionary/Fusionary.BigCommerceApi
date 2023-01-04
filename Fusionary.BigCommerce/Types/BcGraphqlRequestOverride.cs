namespace Fusionary.BigCommerce.Types;

public record BcGraphqlRequestOverride: BcRequestOverride
{
    /// <summary>
    /// Override Storefront Url for this request
    /// </summary>
    public string? StorefrontUrl { get; set; }

    /// <summary>
    /// Override ChannelId for this request
    /// </summary>
    public int? ChannelId { get; set; }
}