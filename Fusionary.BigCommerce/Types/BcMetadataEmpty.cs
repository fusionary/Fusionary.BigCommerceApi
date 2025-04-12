namespace Fusionary.BigCommerce.Types;

public record BcMetadataEmpty: BcExtensionData
{
    /// <inheritdoc />
    public override string ToString() => BcJsonUtil.Serialize(this);
}