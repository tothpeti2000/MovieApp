using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Movies
{
    public class ShortMovieDetails
    {
        public int ID { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        public bool Adult { get; set; }
        public string Overview { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("genre_ids")]
        public int[] GenreIDs { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        public string Title { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        public float Popularity { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        public bool Video { get; set; }

        [JsonProperty("vote_average")]
        public float VoteAverage { get; set; }
    }
}
