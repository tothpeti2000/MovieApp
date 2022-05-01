using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Shows
{
    public class ShortShowDetails
    {
        public int ID { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("first_air_date")]
        public string FirstAirDate { get; set; }

        [JsonProperty("genre_ids")]
        public int[] GenreIDs { get; set; }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        public string Overview { get; set; }

        [JsonProperty("origin_country")]
        public string[] OriginCountry { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        public float Popularity { get; set; }

        public string Name { get; set; }

        [JsonProperty("vote_average")]
        public float VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }
    }
}
