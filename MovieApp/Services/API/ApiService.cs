using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services.API
{
    public class ApiService: IApiService
    {
        // API URL and apiKey which is required for all requests
        private readonly Uri baseURL = new Uri("https://api.themoviedb.org/3/");
        private readonly string apiKey = "780aae170739c0d86c29396d5f6d279f";

        // Generic GET request
        public async Task<T> GetAsync<T>(string path)
        {
            using (var client = new HttpClient())
            {
                // Add the apiKey to each request as a query param
                var fullPath = AddAPIKeyToPath(path);
                // Create the full request URL by combining the baseURL and the request specific path
                var uri = new Uri(baseURL, fullPath);

                // Convert the response JSON to an object of type T
                var response = await client.GetAsync(uri);
                var json = await response.Content.ReadAsStringAsync();

                T result = JsonConvert.DeserializeObject<T>(json);

                return result;
            }
        }

        // Append the API key to the provided request path
        // Use ? if there are no other query params, otherwise, use & to append the API key
        private string AddAPIKeyToPath(string path)
        {
            var separator = path.Contains("?") ? "&" : "?";
            return $"{path}{separator}api_key={apiKey}";
        }
    }
}
