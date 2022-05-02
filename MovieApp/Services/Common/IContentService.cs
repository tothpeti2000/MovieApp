using MovieApp.Models.Common;
using MovieApp.Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services.Common
{
    public interface IContentService<T1, T2>
    {
        Task<PagedResponse<T1>> GetPopularAsync(int page = 1);
        Task<T2> GetDetailsByIDAsync(int ID);
        Task<PagedResponse<T1>> GetByGenreAsync(int genreID, int page = 1);
        Task<PagedResponse<T1>> GetByKeywordsAsync(int[] keywordIDs, int page = 1);
        Task<PagedResponse<T1>> GetByQueryAsync(string query, int page = 1);
        Task<Credits> GetCreditsByIDAsync(int ID);
        Task<PagedResponse<T1>> GetSimilarByIDAsync(int ID, int page = 1);

        Task<GenreList> GetGenresAsync();
    }
}
