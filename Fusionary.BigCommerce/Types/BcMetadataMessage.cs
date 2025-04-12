namespace Fusionary.BigCommerce.Types;

public record BcMetadataMessage: BcMetadataEmpty
{
    public string? Message { get; set; }
}