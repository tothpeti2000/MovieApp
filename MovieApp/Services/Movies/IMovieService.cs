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
        Task<PagedResponse<ShortMovieDetails>> GetByGenreAsync(int genreID, int page = 1);
        Task<PagedResponse<ShortMovieDetails>> GetByKeywordsAsync(int[] keywordIDs, int page = 1);
    }
}
