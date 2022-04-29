using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Shows
{
    public class ShowReview
    {
        public string ID { get; set; }
        public string Author { get; set; }
        public Author Author_Details { get; set; }
        public string Content { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public string Url { get; set; }
    }

    public class Author
    {
        public string name { get; set; }
        public string username { get; set; }
        public string avatar_path { get; set; }
        public int rating { get; set; }
    }
}
