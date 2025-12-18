namespace Fusionary.BigCommerce.Types;

public class BcTimestampConverter : JsonConverter<BcTimestamp>
{
    public override BcTimestamp Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    ) =>
        reader switch
        {
            { TokenType: JsonTokenType.Number } => new BcTimestamp(reader.GetInt32()),
            { TokenType: JsonTokenType.Null } => new BcTimestamp(0),
            _ => throw new JsonException($"Cannot convert {reader.TokenType} to BcTimestamp")
        };

    public override void Write(
        Utf8JsonWriter writer,
        BcTimestamp value,
        JsonSerializerOptions options
    )
    {
        if (value.HasValue)
        {
            writer.WriteNumberValue(value.Value);
        }
        else
        {
            writer.WriteNullValue();
        }
    }
}
