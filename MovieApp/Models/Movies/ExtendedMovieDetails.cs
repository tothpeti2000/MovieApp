using MovieApp.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Movies
{
    public class ExtendedMovieDetails
    {
        public int ID { get; set; }
        public bool Adult { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        public int Budget { get; set; }
        public Genre[] Genres { get; set; }
        public string HomePage { get; set; }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        public string Overview { get; set; }
        public float Popularity { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("production_companies")]
        public Company[] ProductionCompanies { get; set; }

        [JsonProperty("production_countries")]
        public Country[] ProductionCountries { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        public int Revenue { get; set; }
        public int RunTime { get; set; }

        [JsonProperty("spoken_languages")]
        public Language[] SpokenLanguages { get; set; }

        public string Status { get; set; }
        public string TagLine { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }

        [JsonProperty("vote_average")]
        public float VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }
    }
}
