using Microsoft.AspNetCore.Mvc;

namespace consumption_news_weather_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HistoryAPI : ControllerBase
    {
        [HttpGet(Name = "GetHistory")]
        public async Task<List<Contract.HistoryResponse>> GetHistory()
        {
            Model.DAO.History historyDAO = new();
            List<Model.Entity.History> historyList = historyDAO.GetAll();
            List < Contract.HistoryResponse > listHistoryResponse= new();

            ExternalAPI.WeatherExternalAPI weatherExternalAPI = new();
            ExternalAPI.NewsExternalAPI newsExternalAPI = new();

            foreach (Model.Entity.History history in historyList) {
                listHistoryResponse.Add(new Contract.HistoryResponse(history.city,
                    new Contract.InfoResponse(
                        await weatherExternalAPI.KnowWeather(history.city), await newsExternalAPI.KnowNews(history.city))));
            }

            return listHistoryResponse;
        }
    }
}
