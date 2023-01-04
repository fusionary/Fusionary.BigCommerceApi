using System.Text.Json;

namespace Fusionary.BigCommerce.Types;

public class BcFloatConverter : JsonConverter<BcFloat>
{
    public override BcFloat Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    ) =>
        reader switch
        {
            { TokenType: JsonTokenType.Number } => new BcFloat(reader.GetDecimal()),
            { TokenType: JsonTokenType.String } => new BcFloat(reader.GetString()),
            _ => throw new JsonException()
        };

    public override void Write(
        Utf8JsonWriter writer,
        BcFloat @float,
        JsonSerializerOptions options
    ) =>
        writer.WriteStringValue(@float.ToString());
}