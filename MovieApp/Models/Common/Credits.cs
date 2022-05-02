using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Common
{
    public class Credits
    {
        public int ID { get; set; }
        public Cast[] Cast { get; set; }
        public Crew[] Crew { get; set; }
    }

    public class Cast
    {
        public int ID { get; set; }

        [JsonProperty("credit_id")]
        public string CreditID { get; set; }

        public bool Adult { get; set; }
        public int Gender { get; set; }

        [JsonProperty("known_for_department")]
        public string KnownForDepartment { get; set; }

        public string Name { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        public float Popularity { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }

        public string Character { get; set; }
        public int Order { get; set; }
    }

    public class Crew
    {
        public int ID { get; set; }

        [JsonProperty("credit_id")]
        public string CreditID { get; set; }

        public bool Adult { get; set; }
        public int Gender { get; set; }

        [JsonProperty("known_for_department")]
        public string KnownForDepartment { get; set; }

        public string Name { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        public float Popularity { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }

        public string Department { get; set; }
        public string Job { get; set; }
    }
}
