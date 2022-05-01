using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Shows
{
    public class ExtendedEpisodeDetails
    {
        public int ID { get; set; }

        [JsonProperty("air_date")]
        public string AirDate { get; set; }

        [JsonProperty("episode_number")]
        public int EpisodeNumber { get; set; }

        public string Name { get; set; }
        public string Overview { get; set; }

        [JsonProperty("season_number")]
        public int SeasonNumber { get; set; }

        [JsonProperty("still_path")]
        public string StillPath { get; set; }

        [JsonProperty("vote_average")]
        public float VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        public Crew[] Crew { get; set; }

        [JsonProperty("guest_stars")]
        public Cast[] GuestStars { get; set; }
    }
}
