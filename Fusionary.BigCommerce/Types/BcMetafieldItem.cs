namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{Key}:{Value}")]
public record BcMetafieldItem
{
    /// <summary>
    /// The name of the field
    /// </summary>
    /// <example>"location_id" or "color"</example>
    /// <remarks>
    /// REQUIRED &lt;= 1 characters &gt;= 64 characters
    /// </remarks>
    public string Key { get; set; } = null!;

    /// <summary>
    /// The value of the field
    /// </summary>
    /// <example>"Ronaldo"</example>
    /// <remarks>
    /// REQUIRED &lt;= 1 characters &gt;= 65535 characters
    /// </remarks>
    public string Value { get; set; } = null!;

    /// <summary>
    /// Description for the metafields.
    /// </summary>
    /// <example>"Name of Staff Member"</example>
    /// <remarks>
    /// &lt;= 1 characters &gt;= 255 characters
    /// </remarks>
    public string? Description { get; set; }

    public BcMetafieldPost ToMetafieldPost(BcPermissionSet permissionSet, string metafieldNamespace) => new()
    {
        PermissionSet = permissionSet,
        Namespace = metafieldNamespace,
        Key = Key,
        Value = Value,
        Description = Description
    };
}