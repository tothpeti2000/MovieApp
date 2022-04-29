using MovieApp.Models.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Shows
{
    public class ShowDetails: ContentDetails
    {
        public Created_By[] Created_By { get; set; }
        public int[] Episode_Run_Time { get; set; }
        public string First_Air_Date { get; set; }
        public bool In_Production { get; set; }
        public string[] Languages { get; set; }
        public string Last_Air_Date { get; set; }
        public Last_Episode_To_Air Last_Episode_To_Air { get; set; }
        public string Name { get; set; }
        public object Next_Episode_To_Air { get; set; }
        public Network[] Networks { get; set; }
        public int Number_Of_Episodes { get; set; }
        public int Number_Of_Seasons { get; set; }
        public string[] Origin_Country { get; set; }
        public string Original_Name { get; set; }
        public Season[] Seasons { get; set; }
        public string Type { get; set; }
    }

    public class Last_Episode_To_Air
    {
        public string air_date { get; set; }
        public int episode_number { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string overview { get; set; }
        public string production_code { get; set; }
        public int season_number { get; set; }
        public string still_path { get; set; }
        public float vote_average { get; set; }
        public int vote_count { get; set; }
    }

    public class Created_By
    {
        public int id { get; set; }
        public string credit_id { get; set; }
        public string name { get; set; }
        public int gender { get; set; }
        public string profile_path { get; set; }
    }

    public class Network
    {
        public string name { get; set; }
        public int id { get; set; }
        public string logo_path { get; set; }
        public string origin_country { get; set; }
    }

    public class Season
    {
        public string air_date { get; set; }
        public int episode_count { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }
        public int season_number { get; set; }
    }
}
