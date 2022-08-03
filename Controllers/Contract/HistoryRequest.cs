namespace consumption_news_weather_api.Controllers.Contract
{
    public class HistoryResponse {
        public String City { get; set; }
        public InfoResponse Info { get; set; }

        public HistoryResponse(String City, InfoResponse Info)
        {
            this.City = City;
            this.Info = Info;
        }
    }

    public class InfoResponse
    {
        public String Weather { get; set; }
        public String News { get; set; }

        public InfoResponse(String Weather, String News)
        {
            this.Weather = Weather;
            this.News = News;
        }

    }
}
