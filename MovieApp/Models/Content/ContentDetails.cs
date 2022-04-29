using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Content
{
    public class ContentDetails
    {
        public int ID { get; set; }
        public string Backdrop_Path { get; set; }
        public Genre[] Genres { get; set; }
        public string Homepage { get; set; }
        public string Overview { get; set; }
        public float Popularity { get; set; }
        public string Poster_Path { get; set; }
        public Production_Countries[] Production_Countries { get; set; }
        public Production_Companies[] Production_Companies { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public float Vote_average { get; set; }
        public int Vote_count { get; set; }
        public string Original_Language { get; set; }
        public Spoken_Languages[] Spoken_Languages { get; set; }
    }

    public class Genre
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Production_Countries
    {
        public string iso_3166_1 { get; set; }
        public string name { get; set; }
    }

    public class Production_Companies
    {
        public int id { get; set; }
        public string logo_path { get; set; }
        public string name { get; set; }
        public string origin_country { get; set; }
    }

    public class Spoken_Languages
    {
        public string english_name { get; set; }
        public string iso_639_1 { get; set; }
        public string name { get; set; }
    }
}
