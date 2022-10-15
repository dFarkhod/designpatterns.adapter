using Newtonsoft.Json;
using System;

namespace AdapterPattern
{
    public class JsonConverter
    {
        private weather _weather;

        public JsonConverter(weather weather)
        {
            _weather = weather;
        }

        public string ConvertToJson()
        {
            var jsonWeather = JsonConvert.SerializeObject(_weather, Formatting.Indented);
            Console.WriteLine("JSON:");
            Console.WriteLine(jsonWeather);
            return jsonWeather;
        }
    }
}
