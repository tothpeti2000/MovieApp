using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Common
{
    public class GenreList
    {
        public Genre[] genres { get; set; }
    }

    public class Genre
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
