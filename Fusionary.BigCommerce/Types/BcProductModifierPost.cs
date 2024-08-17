namespace Fusionary.BigCommerce.Types;

public record BcProductModifierPost : IExtensionData
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; } = null!;

    public BcProductModifierType Type { get; set; }

    public bool Required { get; set; }

     
    [JsonConverter(typeof(EmptyArrayToObjectConverter<BcOptionConfig>))]
    public BcOptionConfig? Config { get; set; }

    public List<BcModifierOptionValue>? OptionValues { get; set; }


    [JsonPropertyName("shared_option_id")]
    public int? SharedOptionId { get; set; }

    public class EmptyArrayToObjectConverter<T> : JsonConverter<T?>
    where T : class
    {
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // If the token is an empty array, return null
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                reader.Read(); // Move past the start of the array
                if (reader.TokenType == JsonTokenType.EndArray)
                {
                    return null; // Return null if the array is empty
                }
                throw new JsonException("Expected empty array or object");
            }

            // Otherwise, deserialize the object normally
            return JsonSerializer.Deserialize<T>(ref reader, options);
        }

        public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteStartArray();
                writer.WriteEndArray();
            }
            else
            {
                JsonSerializer.Serialize(writer, value, options);
            }
        }
    }

    /// <inheritdoc />
    public IDictionary<string, JsonElement>? ExtensionData { get; init; }
}