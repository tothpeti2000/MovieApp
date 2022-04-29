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
        private readonly IApiService apiService;

        public ShowService(IApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task<PagedResponse<PopularShow>> GetPopularShowsAsync()
        {
            return await apiService.GetAsync<PagedResponse<PopularShow>>("tv/popular");
        }

        public async Task<ShowDetails> GetShowDetailsByIDAsync(int ID)
        {
            return await apiService.GetAsync<ShowDetails>($"tv/{ID}");
        }

        public async Task<Credits> GetShowCreditsByIDAsync(int ID)
        {
            return await apiService.GetAsync<Credits>($"tv/{ID}/credits");
        }

        public async Task<PagedResponse<ShowReview>> GetShowReviewsByIDAsync(int ID)
        {
            return await apiService.GetAsync<PagedResponse<ShowReview>>($"tv/{ID}/reviews");
        }
    }
}
