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
        public OptionValue? OptionValue { get; set; }
    }

    public partial class OptionValue
    {
        public long? Integer { get; set; }
        public string? String { get; set; }

        public static implicit operator OptionValue(long integer) => new OptionValue { Integer = integer };
        public static implicit operator OptionValue(string str) => new OptionValue { String = str };
    }



    
}
