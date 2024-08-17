namespace Fusionary.BigCommerce.Types;
using System.Text.Json;
using System.Text.Json.Serialization;
public record BcOptionConfig : IExtensionData
{
    /// <summary>
    /// The default value. Shown on a date option as an ISO-8601–formatted string, or on a text option as a string.
    /// </summary>
    [JsonPropertyName("default_value")] 
    public object? DefaultValue { get; set; }

    /// <summary>
    /// Flag for setting the checkbox to be checked by default.
    /// </summary>
    [JsonPropertyName("checked_by_default")]
    public bool? CheckedByDefault { get; set; }

    /// <summary>
    /// Label displayed for the checkbox option.
    /// </summary>
    [JsonPropertyName("checkbox_label")]
    public string? CheckboxLabel { get; set; }

    /// <summary>
    /// Flag to limit the dates allowed to be entered on a date option.
    /// </summary>
    [JsonPropertyName("date_limited")]
    public bool? DateLimited { get; set; }

    /// <summary>
    /// The type of limit that is allowed to be entered on a date option.
    /// </summary>
    [JsonPropertyName("date_limit_mode")]
    public BcDateLimitMode? DateLimitMode { get; set; }

    /// <summary>
    /// The earliest date allowed to be entered on the date option, as an ISO-8601 formatted string.
    /// </summary>
    [JsonPropertyName("date_earliest_value")]
    public BcDateTime? DateEarliestValue { get; set; }

    /// <summary>
    /// The latest date allowed to be entered on the date option, as an ISO-8601 formatted string.
    /// </summary>
    [JsonPropertyName("date_latest_value")]
    public string? DateLatestValue { get; set; }

    /// <summary>
    /// The kind of restriction on the file types that can be uploaded with a file upload option. Values: specific - restricts
    /// uploads to particular file types; all - allows all file types.
    /// </summary>
    [JsonPropertyName("file_types_mode")]
    public BcFileTypesMode? FileTypesMode { get; set; }

    /// <summary>
    /// The type of files allowed to be uploaded if the file_type_option is set to specific. Values: images - Allows upload of
    /// image MIME types (bmp, gif, jpg, jpeg, jpe, jif, jfif, jfi, png, wbmp, xbm, tiff). documents - Allows upload of
    /// document MIME types (txt, pdf, rtf, doc, docx, xls, xlsx, accdb, mdb, one, pps, ppsx, ppt, pptx, pub, odt, ods, odp,
    /// odg, odf). other - Allows file types defined in the file_types_other array.
    /// </summary>
    /// <example>["images","documents","other"]</example>
    [JsonPropertyName("file_types_supported")]
    public string[]? FileTypesSupported { get; set; }

    /// <summary>
    /// A list of other file types allowed with the file upload option.
    /// </summary>
    /// <example>["pdf","txt"]</example>
    [JsonPropertyName("file_types_other")]
    public string[]? FileTypesOther { get; set; }

    /// <summary>
    /// The maximum size for a file that can be used with the file upload option. This will still be limited by the server.
    /// </summary>
    [JsonPropertyName("file_max_size")]
    public int? FileMaxSize { get; set; }

    /// <summary>
    /// Flag to validate the length of a text or multi-line text input.
    /// </summary>
    [JsonPropertyName("file_max_size_unit")]
    public bool? TextCharactersLimited { get; set; }

    /// <summary>
    /// The minimum length allowed for a text or multi-line text option.
    /// </summary>
    [JsonPropertyName("text_min_length")]
    public int? TextMinLength { get; set; }

    /// <summary>
    /// The maximum length allowed for a text or multi line text option.
    /// </summary>
    [JsonPropertyName("text_max_length")]
    public int? TextMaxLength { get; set; }

    /// <summary>
    /// Flag to validate the maximum number of lines allowed on a multi-line text input.
    /// </summary>
    [JsonPropertyName("text_characters_limited")]
    public bool? TextLinesLimited { get; set; }

    /// <summary>
    /// The maximum number of lines allowed on a multi-line text input.
    /// </summary>
    [JsonPropertyName("text_max_lines")]
    public int? TextMaxLines { get; set; }

    /// <summary>
    /// Flag to limit the value of a number option.
    /// </summary>
    [JsonPropertyName("number_limited")]
    public bool? NumberLimited { get; set; }

    /// <summary>
    /// The type of limit on values entered for a number option.
    /// </summary>
    [JsonPropertyName("number_limit_mode")]
    public string? NumberLimitMode { get; set; }

    /// <summary>
    /// The lowest allowed value for a number option if number_limited is true.
    /// </summary>
    [JsonPropertyName("number_lowest_value")]
    public int? NumberLowestValue { get; set; }

    /// <summary>
    /// The highest allowed value for a number option if number_limited is true.
    /// </summary>
    [JsonPropertyName("number_highest_value")]
    public int? NumberHighestValue { get; set; }

    /// <summary>
    /// Flag to limit the input on a number option to whole numbers only.
    /// </summary>
    [JsonPropertyName("number_integers_only")]
    public bool? NumberIntegersOnly { get; set; }

    /// <summary>
    /// Flag for automatically adjusting inventory on a product included in the list.
    /// </summary>
    [JsonPropertyName("product_list_adjusts_inventory")]
    public bool? ProductListAdjustsInventory { get; set; }

    /// <summary>
    /// Flag to add the optional product's price to the main product's price.
    /// </summary>
    [JsonPropertyName("product_list_adjusts_pricing")]
    public bool? ProductListAdjustsPricing { get; set; }

    /// <summary>
    /// How to factor the optional product's weight and package dimensions into the shipping quote. Values: none - don't
    /// adjust; weight - use shipping weight only; package - use weight and dimensions.
    /// </summary>
    [JsonPropertyName("product_list_shipping_calc")]
    public BcProductListShippingCalc? ProductListShippingCalc { get; set; }

    /// <inheritdoc />
    public IDictionary<string, JsonElement>? ExtensionData { get; init; }


    public class StringOrNumberConverter : JsonConverter<string?>
    {
        public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Check if the JSON token is null
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null; // Return null if the token is null
            }
            // Check if the JSON token is a number
            if (reader.TokenType == JsonTokenType.Number)
            {
                // Convert the number to a string
                return reader.GetInt64().ToString();
            }
            // Check if the JSON token is a string
            else if (reader.TokenType == JsonTokenType.String)
            {
                return reader.GetString();
            }

            throw new JsonException("Expected number, string, or null");
        }

        public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue(); // Write a null value if the string is null
            }
            else
            {
                writer.WriteStringValue(value); // Otherwise, write the string value
            }
        }
    }
}