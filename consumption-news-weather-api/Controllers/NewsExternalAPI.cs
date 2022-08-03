using Microsoft.AspNetCore.Mvc;

namespace consumption_news_weather_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsExternalAPI : ControllerBase
    {
        [HttpGet(Name = "GetNews")]
        public async Task<string> GetNews(string city)
        {
            Model.DAO.History historyDAO = new();
            historyDAO.Save(new Model.Entity.History(city));

            ExternalAPI.NewsExternalAPI newsExternalAPI = new();

            return await newsExternalAPI.KnowNews(city);
        }
    }
}
