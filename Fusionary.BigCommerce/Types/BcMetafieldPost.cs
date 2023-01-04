namespace Fusionary.BigCommerce.Types;

public record BcMetafieldPost: BcMetafieldItem
{
    /// <summary>
    /// Determines the visibility and writeability of the field by other API consumers.
    /// </summary>
    /// <remarks>
    /// REQUIRED
    /// </remarks>
    public BcPermissionSet PermissionSet { get; set; } = BcPermissionSet.Read;

    /// <summary>
    /// Namespace for the metafield, for organizational purposes.
    /// </summary>
    /// <remarks>
    /// REQUIRED &lt;= 1 characters &gt;= 64 characters
    /// </remarks>
    public string Namespace { get; set; } = null!;
}