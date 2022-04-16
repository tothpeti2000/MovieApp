using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Shows
{
    public class ShowRecommendation
    {
        public int User_Count { get; set; }
        public Show Show { get; set; }
    }

    public class Show
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Ids Ids { get; set; }
    }

    public class Ids
    {
        public int Trakt { get; set; }
        public string Slug { get; set; }
        public int Tvdb { get; set; }
        public string Imdb { get; set; }
        public int Tmdb { get; set; }
    }

}
