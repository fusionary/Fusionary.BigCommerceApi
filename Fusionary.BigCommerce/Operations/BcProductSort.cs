namespace Fusionary.BigCommerce.Operations;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcProductSort
{
    [JsonPropertyName("id")]
    Id,

    [JsonPropertyName("name")]
    Name,

    [JsonPropertyName("sku")]
    Sku,

    [JsonPropertyName("date_modified")]
    DateModified,

    [JsonPropertyName("date_last_imported")]
    DateLastImported,

    [JsonPropertyName("inventory_level")]
    InventoryLevel,

    [JsonPropertyName("is_visible")]
    IsVisible,

    [JsonPropertyName("total_sold")]
    TotalSold
}