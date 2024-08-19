using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusionary.BigCommerce.Types
{
    public record BcCartRedirectQueryParms
    {


        [JsonPropertyName("query_params")]
        public QueryParams? QueryParameters { get; set; }


        public partial class QueryParams
        {
            [JsonPropertyName("key_1")]
            public string? Key1 { get; set; }

            [JsonPropertyName("key_2")]
            public string? Key2 { get; set; }
        }

    }
}
