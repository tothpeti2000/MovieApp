﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Shows
{
    public class Credits
    {
        public int ID { get; set; }
        public Cast[] Cast { get; set; }
        public Crew[] Crew { get; set; }
    }

    public class Cast
    {
        public bool adult { get; set; }
        public int gender { get; set; }
        public int id { get; set; }
        public string known_for_department { get; set; }
        public string name { get; set; }
        public string original_name { get; set; }
        public float popularity { get; set; }
        public string profile_path { get; set; }
        public string character { get; set; }
        public string credit_id { get; set; }
        public int order { get; set; }
    }

    public class Crew
    {
        public bool adult { get; set; }
        public int gender { get; set; }
        public int id { get; set; }
        public string known_for_department { get; set; }
        public string name { get; set; }
        public string original_name { get; set; }
        public float popularity { get; set; }
        public string profile_path { get; set; }
        public string credit_id { get; set; }
        public string department { get; set; }
        public string job { get; set; }
    }
}