using MovieApp.Models.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Movies
{
    public class PopularMovie: PopularContent
    {
        public string release_date { get; set; }
        public string title { get; set; }
    }
}
