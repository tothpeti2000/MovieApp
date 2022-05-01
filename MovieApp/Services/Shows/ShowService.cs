﻿using MovieApp.Models.Shows;
using MovieApp.Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services.Shows
{
    public class ShowService : IShowService
    {
        private readonly IApiService apiService;

        public ShowService(IApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task<PagedResponse<PopularShow>> GetPopularAsync()
        {
            return await apiService.GetAsync<PagedResponse<PopularShow>>("tv/popular");
        }

        public async Task<ShowDetails> GetDetailsByIDAsync(int ID)
        {
            return await apiService.GetAsync<ShowDetails>($"tv/{ID}");
        }

        public Task<PagedResponse<T>> GetByGenreAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PagedResponse<T>> GetByKeywordsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PagedResponse<T>> GetByQueryAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Credits> GetCreditsByIDAsync(int ID)
        {
            return await apiService.GetAsync<Credits>($"tv/{ID}/credits");
        }

        public Task<PagedResponse<T>> GetSimilarAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TResult> GetSeasonDetailsByIDAsync(int ID, int season)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> GetEpisodeDetailsByIDAsync(int ID, int season, int episode)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> GetGenresAsync()
        {
            throw new NotImplementedException();
        }
    }
}
