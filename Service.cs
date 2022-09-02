using System.Text.Json;

namespace Scrapper
{
    public class Service
    {
        private readonly Client _client;

        public Service()
        {
            _client = new Client();
        }

        public Models.Root<T> GetRecords<T>(string url) where T : class
        {
            string? json = _client.Read(url);
            var options = new JsonSerializerOptions(){ PropertyNameCaseInsensitive = true };
            return JsonSerializer.Deserialize<Models.Root<T>>(json, options)!;
        }
    }
}