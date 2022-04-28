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
        // API URL and apiKey which is required for all requests
        private readonly Uri baseURL = new Uri("https://api.themoviedb.org/3");
        private readonly string apiKey = "780aae170739c0d86c29396d5f6d279f";

        // Generic GET request
        public async Task<T> GetAsync<T>(string path)
        {
            using (var client = new HttpClient())
            {
                // Add the apiKey to each request as a query param
                path += $"&api_key={apiKey}";
                // Create the full request URL by combining the baseURL and the request specific path
                var uri = new Uri(baseURL, path);

                // Convert the response JSON to an object with type T
                var response = await client.GetAsync(uri);
                var json = await response.Content.ReadAsStringAsync();

                T result = JsonConvert.DeserializeObject<T>(json);

                return result;
            }
        }
    }
}
