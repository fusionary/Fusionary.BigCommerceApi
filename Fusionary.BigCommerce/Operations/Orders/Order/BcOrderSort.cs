namespace Fusionary.BigCommerce.Operations;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcOrderSort
{
    [JsonPropertyName("id")]
    Id,

    [JsonPropertyName("id:desc")]
    IdDesc,

    [JsonPropertyName("customer_id")]
    CustomerId,

    [JsonPropertyName("customer_id:desc")]
    CustomerIdDesc,

    [JsonPropertyName("date_created")]
    DateCreated,

    [JsonPropertyName("date_created:desc")]
    DateCreatedDesc,

    [JsonPropertyName("date_modified")]
    DateModified,

    [JsonPropertyName("date_modified:desc")]
    DateModifiedDesc,

    [JsonPropertyName("status_id")]
    StatusId,

    [JsonPropertyName("status_id:desc")]
    StatusIdDesc,

    [JsonPropertyName("channel_id")]
    ChannelId,

    [JsonPropertyName("channel_id:desc")]
    ChannelIdDesc,

    [JsonPropertyName("external_id")]
    ExternalId,

    [JsonPropertyName("external_id:desc")]
    ExternalIdDesc
}