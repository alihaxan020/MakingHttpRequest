﻿namespace MakingHttpRequest
{
    public interface IWeatherService
    {
        Task<string> Get(string cityName);
    }
    public class WeatherService : IWeatherService
    {
        private HttpClient _httpClient;
        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;   
        }

        public async Task<string> Get(string cityName)
        {
            var apiKey = "147ed228ce99432fba6171437222410";
            var APIURL = $"?key={apiKey}&q={cityName}";
            var response = await _httpClient.GetAsync(APIURL);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
