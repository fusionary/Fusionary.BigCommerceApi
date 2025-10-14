namespace Fusionary.BigCommerce.Types;

public class BcDateTimeConverter : JsonConverter<BcDateTime>
{
    public override BcDateTime Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    ) =>
        reader switch
        {
            { TokenType: JsonTokenType.String } => new BcDateTime(reader.GetString()),
            { TokenType: JsonTokenType.Number } => new BcDateTime(DateTimeOffset.FromUnixTimeSeconds(reader.GetInt64())),
            _ => throw new JsonException()
        };

    public override void Write(
        Utf8JsonWriter writer,
        BcDateTime value,
        JsonSerializerOptions options
    )
    {
        if (value.HasValue)
        {
            writer.WriteStringValue(value.ToString());
        }
        else
        {
            writer.WriteNullValue();
        }
    }
}