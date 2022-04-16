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
        private readonly Uri baseURL = new Uri("https://api.trakt.tv");
        private readonly string apiKey = "b0c4acf1d122aedc3837c936541d7b20c3ff4f3c8f3369f8df410b1ca6dd273a";
        private readonly int apiVersion = 2;

        public async Task<T> GetAsync<T>(string path)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("trakt-api-version", apiVersion.ToString());
                client.DefaultRequestHeaders.Add("trakt-api-key", apiKey);

                var uri = new Uri(baseURL, path);

                var response = await client.GetAsync(uri);
                var json = await response.Content.ReadAsStringAsync();

                T result = JsonConvert.DeserializeObject<T>(json);

                return result;
            }
        }
    }
}
