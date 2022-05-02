using MovieApp.Models.Common;
using MovieApp.Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services.Common
{
    public class ContentService<T1, T2> : IContentService<T1, T2>
    {
        private readonly IApiService apiService;
        private readonly string contentType;

        public ContentService(IApiService apiService, string contentType)
        {
            this.apiService = apiService;
            this.contentType = contentType;
        }

        public async Task<PagedResponse<T1>> GetPopularAsync(int page = 1)
        {
            return await apiService.GetAsync<PagedResponse<T1>>($"{contentType}/popular?page={page}");
        }

        public async Task<T2> GetDetailsByIDAsync(int ID)
        {
            return await apiService.GetAsync<T2>($"{contentType}/{ID}");
        }

        public async Task<PagedResponse<T1>> GetByGenreAsync(int genreID, int page = 1)
        {
            return await apiService.GetAsync<PagedResponse<T1>>($"discover/{contentType}?with_genres={genreID}&page={page}");
        }

        public async Task<PagedResponse<T1>> GetByKeywordsAsync(int[] keywordIDs, int page = 1)
        {
            string fullKeywordIDs = string.Join(",", keywordIDs);

            return await apiService.GetAsync<PagedResponse<T1>>($"discover/{contentType}?with_keywords={fullKeywordIDs}&page={page}");
        }

        public async Task<PagedResponse<T1>> GetByQueryAsync(string query, int page = 1)
        {
            return await apiService.GetAsync<PagedResponse<T1>>($"search/{contentType}?query={query}&page={page}");
        }

        public async Task<Credits> GetCreditsByIDAsync(int ID)
        {
            return await apiService.GetAsync<Credits>($"{contentType}/{ID}/credits");
        }

        public async Task<PagedResponse<T1>> GetSimilarByIDAsync(int ID, int page = 1)
        {
            return await apiService.GetAsync<PagedResponse<T1>>($"{contentType}/{ID}/similar?page={page}");
        }

        public async Task<GenreList> GetGenresAsync()
        {
            return await apiService.GetAsync<GenreList>($"genre/{contentType}/list");
        }
    }
}
