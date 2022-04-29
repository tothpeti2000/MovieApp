using MovieApp.Models.Movies;
using MovieApp.Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services.Movies
{
    public interface IMovieService
    {
        Task<PagedResponse<SimilarMovie>> GetMoviesWithGenreIDAsync(int genreID);
        Task<PagedResponse<SimilarMovie>> GetMoviesWithKeywordIDsAsync(int[] keywordIDs);
    }
}
