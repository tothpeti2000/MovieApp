﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services.API
{
    public class PagedResponse<T>
    {
        public int Page { get; set; }
        public T[] Results { get; set; }
        public int Total_pages { get; set; }
        public int Total_results { get; set; }
    }
}
