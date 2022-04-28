using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services.API
{
    public interface IApiService
    {
        Task<T> GetAsync<T>(string path);
    }
}
