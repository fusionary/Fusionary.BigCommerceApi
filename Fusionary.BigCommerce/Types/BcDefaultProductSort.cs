namespace Fusionary.BigCommerce.Types;

public enum BcDefaultProductSort
{
    [JsonPropertyName("use_store_settings")]
    UseStoreSettings,

    [JsonPropertyName("featured")]
    Featured,

    [JsonPropertyName("newest")]
    Newest,

    [JsonPropertyName("best_selling")]
    BestSelling,

    [JsonPropertyName("alpha_asc")]
    AlphaAsc,

    [JsonPropertyName("alpha_desc")]
    AlphaDesc,

    [JsonPropertyName("avg_customer_review")]
    AvgCustomerReview,

    [JsonPropertyName("price_asc")]
    PriceAsc,

    [JsonPropertyName("price_desc")]
    PriceDesc
}