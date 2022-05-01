using MovieApp.Models.Shows;
using MovieApp.Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services.Shows
{
    public interface IShowService
    {
        Task<PagedResponse<PopularShow>> GetPopularAsync(int page = 1);
        Task<ShowDetails> GetDetailsByIDAsync(int ID);
        Task<PagedResponse<>> GetByGenreAsync();
        Task<PagedResponse<>> GetByKeywordsAsync();
        Task<PagedResponse<>> GetByQueryAsync();
        Task<Credits> GetCreditsByIDAsync(int ID);
        Task<PagedResponse<>> GetSimilarAsync();
        Task<> GetSeasonDetailsByIDAsync(int ID, int season);
        Task<> GetEpisodeDetailsByIDAsync(int ID, int season, int episode);

        Task<> GetGenresAsync();
    }
}
