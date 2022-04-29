using MovieApp.Models.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Shows
{
    public class PopularShow: PopularContent
    {
        public string First_Air_Date { get; set; }
        public string Name { get; set; }
    }
}
