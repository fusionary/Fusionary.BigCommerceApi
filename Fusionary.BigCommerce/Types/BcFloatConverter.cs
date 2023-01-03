using System.Text.Json;

namespace Fusionary.BigCommerce.Types;

public class BcFloatConverter : JsonConverter<BcFloat>
{
    public override BcFloat Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    ) =>
        new(reader.GetString());

    public override void Write(
        Utf8JsonWriter writer,
        BcFloat @float,
        JsonSerializerOptions options
    ) =>
        writer.WriteStringValue(@float.ToString());
}