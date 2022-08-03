namespace consumption_news_weather_api.ExternalAPI
{
    public class WeatherExternalAPI
    {
        public async Task<string> KnowWeather(string city)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q=" +
                city + "&APPID=e2dce522f2cb47dede3fa6891e5b3b5c";

            using var httpClient = new HttpClient();

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            httpRequestMessage.Headers.Add("User-Agent", "C# Program");
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            return await httpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
