using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Globalization; 

namespace Fusionary.BigCommerce.Types
{
    public record BcCartLineItems : IExtensionData
    {

        public partial class BigCommerceLineItems
        {
            [JsonPropertyName("line_items")]
            public List<BcCartLineItem>? LineItems { get; set; }
        }

       
        public IDictionary<string, JsonElement>? ExtensionData { get; init; }

    }
       
}
