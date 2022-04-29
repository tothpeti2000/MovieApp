using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Content
{
    public class PopularContent
    {
        public int ID { get; set; }
        public string Backdrop_Path { get; set; }
        public int[] Genre_Ids { get; set; }
        public string Original_Language { get; set; }
        public string Overview { get; set; }
        public string Poster_Path { get; set; }
        public float Popularity { get; set; }
        public float Vote_Average { get; set; }
        public int Vote_Count { get; set; }
    }
}
