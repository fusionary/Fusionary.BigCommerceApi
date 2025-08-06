namespace Fusionary.BigCommerce.B2B.Types;

public class B2BCompanyPriceListAssignment
{
    [JsonPropertyName("channelId")]
    public int? ChannelId { get; set; }
    [JsonPropertyName("priceListId")]
    public int? PriceListId { get; set; }
    [JsonPropertyName("priceListName")]
    public string? PriceListName { get; set; }
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }
}