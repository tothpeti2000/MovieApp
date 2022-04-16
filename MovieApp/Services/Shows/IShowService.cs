using MovieApp.Models.Shows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services.Shows
{
    public interface IShowService
    {
        Task<ShowRecommendation[]> GetRecommendedShows();
    }
}
