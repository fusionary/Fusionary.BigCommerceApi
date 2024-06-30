namespace Fusionary.BigCommerce.Types;

public record BcPriceList : BcPriceListPost
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("date_created")]
    public BcDateTime DateCreated { get; set; }

    [JsonPropertyName("date_modified")]
    public BcDateTime DateModified { get; set; }
}