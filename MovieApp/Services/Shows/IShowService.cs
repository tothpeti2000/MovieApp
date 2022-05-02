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
    public interface IShowService: IContentService<ShortShowDetails, ExtendedShowDetails>
    {
        Task<ExtendedSeasonDetails> GetSeasonDetailsByIDAsync(int ID, int season);
        Task<ExtendedEpisodeDetails> GetEpisodeDetailsByIDAsync(int ID, int season, int episode);
    }
}
