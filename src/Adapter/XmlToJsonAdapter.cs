using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace AdapterPattern
{
    public class XmlToJsonAdapter : IDataConversionAdapter
    {
        private readonly string _xmlString;

        public XmlToJsonAdapter(string xmlString)
        {
            _xmlString = xmlString;
        }

        public void Convert()
        {
            var xRoot = new XmlRootAttribute();
            xRoot.ElementName = "weather";
            xRoot.IsNullable = true;
            var serializer = new XmlSerializer(typeof(weather), xRoot);
            var reader = new StringReader(_xmlString);
            var weatherObject = (weather)serializer.Deserialize(reader);
            string jsonWeatherData = new JsonConverter(weatherObject).ConvertToJson();
            File.WriteAllText("weather-data.json", jsonWeatherData);
        }
    }
}
