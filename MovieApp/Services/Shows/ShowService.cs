using MovieApp.Models.Shows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services.Shows
{
    public class ShowService : IShowService
    {
        private readonly ApiService apiService = new ApiService();

        public async Task<ShowRecommendation[]> GetRecommendedShows()
        {
            return await apiService.GetAsync<ShowRecommendation[]>("shows/recommended");
        }
    }
}
