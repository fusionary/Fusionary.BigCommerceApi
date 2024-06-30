namespace Fusionary.BigCommerce.Types;

public class BcIdConverter : JsonConverter<BcId>
{
    public override BcId Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    ) =>
        reader switch
        {
            { TokenType: JsonTokenType.Number } => new BcId(reader.GetInt32()),
            { TokenType: JsonTokenType.String } => new BcId(reader.GetString()),
            _ => throw new JsonException()
        };

    public override void Write(
        Utf8JsonWriter writer,
        BcId value,
        JsonSerializerOptions options
    )
    {
        writer.WriteNumberValue(value.Value);
    }
}