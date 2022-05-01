using MovieApp.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Shows
{
    public class ExtendedShowDetails
    {
        public int ID { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("created_by")]
        public Creator[] CreatedBy { get; set; }

        [JsonProperty("episode_run_time")]
        public int[] EpisodeRunTime { get; set; }

        [JsonProperty("first_air_date")]
        public string FirstAirDate { get; set; }

        public Genre[] Genres { get; set; }
        public string HomePage { get; set; }

        [JsonProperty("in_production")]
        public bool InProduction { get; set; }

        public string[] Languages { get; set; }

        [JsonProperty("last_air_date")]
        public string LastAirDate { get; set; }

        [JsonProperty("last_episode_to_air")]
        public ShortEpisodeDetails LastEpisodeToAir { get; set; }

        public string Name { get; set; }

        [JsonProperty("next_episode_to_air")]
        public ShortEpisodeDetails NextEpisodeToAir { get; set; }

        public Company[] Networks { get; set; }

        [JsonProperty("number_of_episodes")]
        public int NumberOfEpisodes { get; set; }

        [JsonProperty("number_of_seasons")]
        public int NumberOfSeasons { get; set; }

        [JsonProperty("origin_country")]
        public string[] OriginCountry { get; set; }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        public string Overview { get; set; }
        public float Popularity { get; set; }

        [JsonProperty("poster_path")]
        public string Poster_Path { get; set; }

        [JsonProperty("production_companies")]
        public Company[] ProductionCompanies { get; set; }

        [JsonProperty("production_countries")]
        public Country[] ProductionCountries { get; set; }

        public ShortSeasonDetails[] Seasons { get; set; }

        [JsonProperty("spoken_languages")]
        public Language[] SpokenLanguages { get; set; }

        public string Status { get; set; }
        public string TagLine { get; set; }
        public string Type { get; set; }

        [JsonProperty("vote_average")]
        public float VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }
    }

    public class Creator
    {
        public int ID { get; set; }

        [JsonProperty("credit_id")]
        public string CreditID { get; set; }

        public string Name { get; set; }
        public int Gender { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }
    }
}
