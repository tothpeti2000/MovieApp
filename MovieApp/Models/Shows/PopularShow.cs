using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Shows
{
    public class PopularShow
    {
        public int ID { get; set; }
        public string Backdrop_Path { get; set; }
        public string First_Air_Date { get; set; }
        public int[] Genre_Ids { get; set; }
        public string Original_Language { get; set; }
        public string Original_Name { get; set; }
        public string Overview { get; set; }
        public string[] Origin_Country { get; set; }
        public string Poster_Path { get; set; }
        public float Popularity { get; set; }
        public string Name { get; set; }
        public float Vote_Average { get; set; }
        public int Vote_Count { get; set; }
    }
}
