using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Common
{
    public class Company
    {
        public int ID { get; set; }

        [JsonProperty("logo_path")]
        public string LogoPath { get; set; }

        public string Name { get; set; }

        [JsonProperty("origin_country")]
        public string OriginCountry { get; set; }
    }
}
