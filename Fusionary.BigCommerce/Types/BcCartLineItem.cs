using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusionary.BigCommerce.Types
{
    public record BcCartLineItem : IExtensionData
    {


        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        [JsonPropertyName("product_id")]
        public long? ProductId { get; set; }


        [JsonPropertyName("list_price")]
        public double? ListPrice { get; set; }


        [JsonPropertyName("option_selections")]
        public List<OptionSelection>? OptionSelections { get; set; }

        public IDictionary<string, JsonElement>? ExtensionData { get; init; }
    }

    public partial class OptionSelection
    {
        [JsonPropertyName("option_id")]
        public long? OptionId { get; set; }

        [JsonPropertyName("option_value")]
        [JsonConverter(typeof(OptionValueConverter))]
        public OptionValue? OptionValue { get; set; }
    }

    public partial class OptionValue
    {
        public long? Integer { get; set; }
        public string? String { get; set; }

        public static implicit operator OptionValue(long integer) => new OptionValue { Integer = integer };
        public static implicit operator OptionValue(string str) => new OptionValue { String = str };
    }


    public class OptionValueConverter : JsonConverter<OptionValue>
    {
        public override OptionValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Check the token type
            if (reader.TokenType == JsonTokenType.Number)
            {
                return new OptionValue { Integer = reader.GetInt64() };
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                return new OptionValue { String = reader.GetString() };
            }

            throw new JsonException("Invalid type for OptionValue.");
        }

        public override void Write(Utf8JsonWriter writer, OptionValue value, JsonSerializerOptions options)
        {
            if (value.Integer.HasValue)
            {
                writer.WriteNumberValue(value.Integer.Value);
            }
            else if (value.String != null)
            {
                writer.WriteStringValue(value.String);
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }

}
