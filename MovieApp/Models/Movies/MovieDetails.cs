using MovieApp.Models.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Movies
{
    public class MovieDetails: ContentDetails
    {
        public bool adult { get; set; }
        public object belongs_to_collection { get; set; }
        public int budget { get; set; }
        public string imdb_id { get; set; }
        public string original_title { get; set; }
        public string release_date { get; set; }
        public int revenue { get; set; }
        public int runtime { get; set; }
        public string title { get; set; }
        public bool video { get; set; }
    }
}
