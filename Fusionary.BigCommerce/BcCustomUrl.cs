namespace Fusionary.BigCommerce;

public class BcCustomUrl
{
    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;

    [JsonPropertyName("is_customized")]
    public bool IsCustomized { get; set; }
}