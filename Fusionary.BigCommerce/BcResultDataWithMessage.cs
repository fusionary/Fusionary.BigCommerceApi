namespace Fusionary.BigCommerce;

public record BcResultDataWithMessage<TData> : BcResult<TData, BcMetadataMessage>
{
    [JsonPropertyName("code")]
    public string Code { get; init; } = "200";
}