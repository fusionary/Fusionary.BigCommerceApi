namespace Fusionary.BigCommerce.Types;

public record BcProductOptions: IExtensionData
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; } = null!;

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("display_name_customer")]
    public string? DisplayNameCustomer { get; set; }

    [JsonPropertyName("display_name_merchant")]
    public string? DisplayNameMerchant { get; set; }

    [JsonPropertyName("display_value")]
    public string? DisplayValue { get; set; }

    [JsonPropertyName("display_value_customer")]
    public string? DisplayValueCustomer { get; set; }

    [JsonPropertyName("display_value_merchant")]
    public string? DisplayValueMerchant { get; set; }

    /// <inheritdoc />
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? ExtensionData { get; set; }
}
