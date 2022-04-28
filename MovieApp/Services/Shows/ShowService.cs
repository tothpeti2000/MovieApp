using MovieApp.Models.Shows;
using MovieApp.Services.API;
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

        public async Task<PagedResponse<PopularShow>> GetPopularShows()
        {
            return await apiService.GetAsync<PagedResponse<PopularShow>>("tv/popular");
        }

        public Task<ShowDetails> GetShowDetailsByID(int ID)
        {
            return apiService.GetAsync<ShowDetails>($"tv/{ID}");
        }
    }
}
