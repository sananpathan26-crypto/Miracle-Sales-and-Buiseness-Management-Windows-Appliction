using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace miracle
{
    internal class order
    {

        [JsonProperty("customerName")]
        public string name { get; set; }

        public string mobile { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        [JsonProperty("product")]
        public string productName { get; set; }

        [JsonProperty("price")]
        public decimal? productPrice { get; set; }
    }
}
