using MovieApp.Models.Common;
using MovieApp.Models.Movies;
using MovieApp.Services.API;
using MovieApp.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services.Movies
{
    public class MovieService : ContentService<ShortMovieDetails, ExtendedMovieDetails>, IMovieService
    {
        private readonly IApiService apiService;

        public MovieService(IApiService apiService): base(apiService, "movie")
        {
            this.apiService = apiService;
        }
    }
}
