namespace Fusionary.BigCommerce.Types;

public class BcDateConverter : JsonConverter<BcDate>
{
    public override BcDate Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    ) =>
        reader switch
        {
            { TokenType: JsonTokenType.String } => new BcDate(reader.GetString()),
            { TokenType: JsonTokenType.Number } => new BcDate(DateTimeOffset.FromUnixTimeSeconds(reader.GetInt64())),
            _ => throw new JsonException()
        };

    public override void Write(
        Utf8JsonWriter writer,
        BcDate value,
        JsonSerializerOptions options
    )
    {
        if (value.HasValue )
        {
            writer.WriteStringValue(value.ToString());
        }
        else
        {
            writer.WriteNullValue();
        }
    }
}