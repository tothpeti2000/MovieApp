using MovieApp.Models;
using MovieApp.Models.Common;
using MovieApp.Models.Shows;
using MovieApp.Services.API;
using MovieApp.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services.Shows
{
    public class ShowService : ContentService<ShortShowDetails, ExtendedShowDetails>, IShowService
    {
        private readonly IApiService apiService;

        public ShowService(IApiService apiService): base(apiService, "tv")
        {
            this.apiService = apiService;
        }

        public async Task<ExtendedSeasonDetails> GetSeasonDetailsByIDAsync(int ID, int season)
        {
            return await apiService.GetAsync<ExtendedSeasonDetails>($"tv/{ID}/season/{season}");
        }

        public async Task<ExtendedEpisodeDetails> GetEpisodeDetailsByIDAsync(int ID, int season, int episode)
        {
            return await apiService.GetAsync<ExtendedEpisodeDetails>($"tv/{ID}/season/{season}/episode/{episode}");
        }
    }
}
