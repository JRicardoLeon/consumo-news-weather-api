using Microsoft.AspNetCore.Mvc;

namespace consumption_news_weather_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherExternalAPI : ControllerBase
    {
        [HttpGet(Name = "GetWeather")]
        public async Task<string> GetWeather(string city)
        {
            Model.DAO.History historyDAO = new();
            historyDAO.Save(new Model.Entity.History(city));

            ExternalAPI.WeatherExternalAPI weatherExternalAPI = new();

            return await weatherExternalAPI.KnowWeather(city);
        }
    }
}
