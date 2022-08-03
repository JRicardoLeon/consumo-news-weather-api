namespace consumption_news_weather_api.Model.Entity
{
    public partial class History {
        public int id { get; set; }
        public string city { get; set; }

        public History(int id, string city){
            this.id = id;
            this.city = city;
        }

        public History(string city)
        {
            this.id = 0;
            this.city = city;
        }

    }
}
