using System.Net;

namespace Scrapper
{
    public class Client
    {
        private static readonly HttpClient _httpClient;

        static Client()
        {
            _httpClient = new HttpClient();
        }

        public string Read(string uriString)
        {
            uriString += $"&_={DateTime.Now.Ticks}";
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get,uriString);

            using var response = _httpClient.GetAsync(httpRequestMessage.RequestUri).Result;
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}