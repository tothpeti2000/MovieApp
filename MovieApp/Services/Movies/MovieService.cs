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

        public async Task<PagedResponse<SimilarMovie>> GetMoviesWithGenreIDAsync(int genreID)
        {
            return await apiService.GetAsync<PagedResponse<SimilarMovie>>($"discover/movie?with_genres={genreID}");
        }

        public async Task<PagedResponse<SimilarMovie>> GetMoviesWithKeywordIDsAsync(int[] keywordIDs)
        {
            string totalKeywordIDs = "";

            foreach (var ID in keywordIDs)
            {
                totalKeywordIDs += $"{ID},";
            }

            return await apiService.GetAsync<PagedResponse<SimilarMovie>>($"discover/movie?with_keywords={totalKeywordIDs}");
        }
    }
}
