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
        Task<PagedResponse<PopularShow>> GetPopularShowsAsync();
        Task<ShowDetails> GetShowDetailsByIDAsync(int ID);
        Task<Credits> GetShowCreditsByIDAsync(int ID);
        Task<PagedResponse<ShowReview>> GetShowReviewsByIDAsync(int ID);
        Task<PagedResponse<SimilarShow>> GetSimilarShowsByIDAsync(int ID);
        Task<PagedResponse<SimilarShow>> GetShowsWithGenreIDAsync(int genreID);
        Task<PagedResponse<SimilarShow>> GetShowsWithKeywordIDsAsync(int[] keywordIDs);
    }
}
