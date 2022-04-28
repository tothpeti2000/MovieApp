using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services
{
    public class ApiService
    {
        private readonly Uri baseURL = new Uri("https://api.themoviedb.org/3");
        private readonly string apiKey = "780aae170739c0d86c29396d5f6d279f";

        public async Task<T> GetAsync<T>(string path)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(baseURL, path);

                var response = await client.GetAsync(uri);
                var json = await response.Content.ReadAsStringAsync();

                T result = JsonConvert.DeserializeObject<T>(json);

                return result;
            }
        }
    }
}
