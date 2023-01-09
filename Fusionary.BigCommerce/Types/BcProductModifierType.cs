namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum BcProductModifierType
{
    [JsonPropertyName("date")]
    Date,

    [JsonPropertyName("checkbox")]
    Checkbox,

    [JsonPropertyName("file")]
    File,

    [JsonPropertyName("text")]
    Text,

    [JsonPropertyName("multi_line_text")]
    MultiLineText,

    [JsonPropertyName("numbers_only_text")]
    NumbersOnlyText,

    [JsonPropertyName("radio_buttons")]
    RadioButtons,

    [JsonPropertyName("rectangles")]
    Rectangles,

    [JsonPropertyName("dropdown")]
    Dropdown,

    [JsonPropertyName("product_list")]
    ProductList,

    [JsonPropertyName("product_list_with_images")]
    ProductListWithImages,

    [JsonPropertyName("swatch")]
    Swatch
}