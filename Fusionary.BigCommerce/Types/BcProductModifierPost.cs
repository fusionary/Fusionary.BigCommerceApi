namespace Fusionary.BigCommerce.Types;

public record BcProductModifierPost : BcExtensionData
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public BcProductModifierType Type { get; set; }
    
    public bool Required { get; set; }

    [JsonConverter(typeof(BcOptionConfigConverter))]
    public BcOptionConfig? Config { get; set; }

    public List<BcModifierOptionValue>? OptionValues { get; set; }
    
    public int? SharedOptionId { get; set; }
}

// Config is supposed to be an object, but some APIs return it as an empty array instead, which is stupid, so we need
// this thing to handle that.
public class BcOptionConfigConverter : JsonConverter<BcOptionConfig>
{
    public override BcOptionConfig? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        switch (reader.TokenType)
        {
            case JsonTokenType.StartObject:
                return JsonSerializer.Deserialize<BcOptionConfig>(ref reader, options);
            case JsonTokenType.StartArray:
                JsonSerializer.Deserialize<object[]>(ref reader, options);
                return null;
        }

        return null;
    }

    public override void Write(Utf8JsonWriter writer, BcOptionConfig value, JsonSerializerOptions options) => JsonSerializer.Serialize(writer, value, options);
}