namespace consumption_news_weather_api.ExternalAPI
{
    public class NewsExternalAPI
    {
        public async Task<string> KnowNews(string city)
        {
            var url = $"https://newsapi.org/v2/everything?q="
                + city
                + "&from="
                + DateTime.Now.ToString("yyyy-MM-dd")
                + "&sortBy=publishedAt&apiKey=7c363a0b9c8d4928a04458656ec954c3";

            using var httpClient = new HttpClient();

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            httpRequestMessage.Headers.Add("User-Agent", "C# Program");
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            return await httpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
