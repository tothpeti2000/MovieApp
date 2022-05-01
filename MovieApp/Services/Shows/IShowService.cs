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
        Task<PagedResponse<ShortShowDetails>> GetPopularAsync(int page = 1);
        Task<ExtendedShowDetails> GetDetailsByIDAsync(int ID);
        Task<PagedResponse<ShortShowDetails>> GetByGenreAsync(int genreID);
        Task<PagedResponse<ShortShowDetails>> GetByKeywordsAsync(int[] keywordIDs);
        Task<PagedResponse<ShortShowDetails>> GetByQueryAsync(string query, int page = 1);
        Task<Credits> GetCreditsByIDAsync(int ID);
        Task<PagedResponse<ShortShowDetails>> GetSimilarByIDAsync(int ID, int page = 1);
        Task<ExtendedSeasonDetails> GetSeasonDetailsByIDAsync(int ID, int season);
        Task<ExtendedEpisodeDetails> GetEpisodeDetailsByIDAsync(int ID, int season, int episode);

        Task<> GetGenresAsync();
    }
}
