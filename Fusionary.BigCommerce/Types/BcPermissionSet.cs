namespace Fusionary.BigCommerce.Types;

public enum BcPermissionSet
{
    /// <summary>
    /// Private to the app that owns the field
    /// </summary>
    [JsonPropertyName("app_only")]
    AppOnly,

    /// <summary>
    /// Visible to other API consumers
    /// </summary>
    [JsonPropertyName("read")]
    Read,

    /// <summary>
    /// Open for reading and writing by other API consumers
    /// </summary>
    [JsonPropertyName("write")]
    Write,

    /// <summary>
    /// Visible to other API consumers, including on storefront
    /// </summary>
    [JsonPropertyName("read_and_sf_access")]
    ReadAndSfAccess,

    /// <summary>
    /// Open for reading and writing by other API consumers, including on storefront
    /// </summary>
    [JsonPropertyName("write_and_sf_access")]
    WriteAndSfAccess
}