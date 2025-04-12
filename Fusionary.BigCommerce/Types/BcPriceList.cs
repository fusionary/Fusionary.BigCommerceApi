namespace Fusionary.BigCommerce.Types;

public record BcPriceList : BcPriceListPost
{
    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int Id { get; set; }

    [JsonPropertyName("date_created")]
    public BcDateTime DateCreated { get; set; }

    [JsonPropertyName("date_modified")]
    public BcDateTime DateModified { get; set; }
}