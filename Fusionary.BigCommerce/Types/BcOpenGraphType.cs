namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum BcOpenGraphType
{
    [JsonPropertyName("product")]
    Product,

    [JsonPropertyName("album")]
    Album,

    [JsonPropertyName("book")]
    Book,

    [JsonPropertyName("drink")]
    Drink,

    [JsonPropertyName("food")]
    Food,

    [JsonPropertyName("game")]
    Game,

    [JsonPropertyName("movie")]
    Movie,

    [JsonPropertyName("song")]
    Song,

    [JsonPropertyName("tv_show")]
    TvShow
}