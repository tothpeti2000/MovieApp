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

        public async Task<PagedResponse<ShortShowDetails>> GetPopularAsync(int page = 1)
        {
            return await apiService.GetAsync<PagedResponse<ShortShowDetails>>($"tv/popular?page={page}");
        }

        public async Task<ExtendedShowDetails> GetDetailsByIDAsync(int ID)
        {
            return await apiService.GetAsync<ExtendedShowDetails>($"tv/{ID}");
        }

        public async Task<PagedResponse<ShortShowDetails>> GetByGenreAsync(int genreID)
        {
            return await apiService.GetAsync<PagedResponse<ShortShowDetails>>($"discover/tv?with_genres={genreID}");
        }

        public async Task<PagedResponse<ShortShowDetails>> GetByKeywordsAsync(int[] keywordIDs)
        {
            string fullKeywordIDs = "";

            foreach (var keywordID in keywordIDs)
            {
                fullKeywordIDs += $"{keywordID},";
            }

            return await apiService.GetAsync<PagedResponse<ShortShowDetails>>($"discover/tv?with_keywords={fullKeywordIDs}");
        }

        public async Task<PagedResponse<ShortShowDetails>> GetByQueryAsync(string query, int page = 1)
        {
            return await apiService.GetAsync<PagedResponse<ShortShowDetails>>($"search/tv?query={query}&page={page}");
        }

        public async Task<Credits> GetCreditsByIDAsync(int ID)
        {
            return await apiService.GetAsync<Credits>($"tv/{ID}/credits");
        }

        public async Task<PagedResponse<ShortShowDetails>> GetSimilarByIDAsync(int ID, int page = 1)
        {
            return await apiService.GetAsync<PagedResponse<ShortShowDetails>>($"tv/{ID}/similar?page={page}");
        }

        public Task<TResult> GetSeasonDetailsByIDAsync(int ID, int season)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> GetEpisodeDetailsByIDAsync(int ID, int season, int episode)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> GetGenresAsync()
        {
            throw new NotImplementedException();
        }
    }
}
