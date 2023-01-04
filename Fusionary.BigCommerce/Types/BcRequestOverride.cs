namespace Fusionary.BigCommerce.Types;

public record BcRequestOverride
{
    /// <summary>
    /// Override Storehash for this request
    /// </summary>
    public string? StoreHash { get; set; }

    /// <summary>
    /// Override AccessToken for this request
    /// </summary>
    public string? AccessToken { get; set; }
}