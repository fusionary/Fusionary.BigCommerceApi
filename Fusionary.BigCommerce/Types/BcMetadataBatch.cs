namespace Fusionary.BigCommerce.Types;

public record BcMetadataBatch : BcMetadataEmpty
{
    [JsonPropertyName("saved_records")]
    public int? SavedRecords { get; set; }
}