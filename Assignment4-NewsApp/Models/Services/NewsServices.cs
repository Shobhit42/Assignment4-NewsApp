using Assignment4_NewsApp.Models.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace Assignment4_NewsApp.Models.Services
{
    public class NewsService : INewsServices
    {
        private readonly HttpClient _httpClient;
       
        public NewsService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "MyNewsApp/1.0");
        }

        public async Task<News?> GetNewsArticles()
        {
            try
            {
                Console.WriteLine($"Sending request to URL: {ConfigurationManager.GetCompleteApi()}");
                
                var response = await _httpClient.GetAsync(ConfigurationManager.GetCompleteApi());

                if (response == null)
                {
                    Console.WriteLine("Response is null.");
                    return null;
                }
                
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Request failed with status code: {response.StatusCode}");
                    return null;
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                var newsData = JsonConvert.DeserializeObject<News>(responseContent);

                return newsData;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
                return null;
            }
        }
    }
}
