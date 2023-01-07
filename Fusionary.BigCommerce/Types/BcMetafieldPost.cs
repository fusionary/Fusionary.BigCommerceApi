namespace Fusionary.BigCommerce.Types;

public record BcMetafieldPost : BcMetafieldItem
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
    /// REQUIRED - Maxlength 64
    /// </remarks>
    public string Namespace { get; set; } = null!;
}