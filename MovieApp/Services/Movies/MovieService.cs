using MovieApp.Models.Common;
using MovieApp.Models.Movies;
using MovieApp.Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services.Movies
{
    public class MovieService : IMovieService
    {
        private readonly IApiService apiService;

        public MovieService(IApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task<PagedResponse<ShortMovieDetails>> GetPopularAsync(int page = 1)
        {
            return await apiService.GetAsync<PagedResponse<ShortMovieDetails>>($"movie/popular?page={page}");
        }

        public async Task<ExtendedMovieDetails> GetDetailsByIDAsync(int ID)
        {
            return await apiService.GetAsync<ExtendedMovieDetails>($"movie/{ID}");
        }

        public async Task<PagedResponse<ShortMovieDetails>> GetByGenreAsync(int genreID, int page = 1)
        {
            return await apiService.GetAsync<PagedResponse<ShortMovieDetails>>($"discover/movie?with_genres={genreID}&page={page}");
        }

        public async Task<PagedResponse<ShortMovieDetails>> GetByKeywordsAsync(int[] keywordIDs, int page = 1)
        {
            string fullKeywordIDs = string.Join(",", keywordIDs);

            return await apiService.GetAsync<PagedResponse<ShortMovieDetails>>($"discover/movie?with_keywords={fullKeywordIDs}&page={page}");
        }

        public async Task<PagedResponse<ShortMovieDetails>> GetByQueryAsync(string query, int page = 1)
        {
            return await apiService.GetAsync<PagedResponse<ShortMovieDetails>>($"search/movie?query={query}&page={page}");
        }

        public async Task<Credits> GetCreditsByIDAsync(int ID)
        {
            return await apiService.GetAsync<Credits>($"movie/{ID}/credits");
        }

        public async Task<PagedResponse<ShortMovieDetails>> GetSimilarByIDAsync(int ID, int page = 1)
        {
            return await apiService.GetAsync<PagedResponse<ShortMovieDetails>>($"movie/{ID}/similar?page={page}");
        }

        public async Task<GenreList> GetGenresAsync()
        {
            return await apiService.GetAsync<GenreList>("genre/movie/list");
        }
    }
}
