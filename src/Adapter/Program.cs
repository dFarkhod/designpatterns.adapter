using System;
using System.IO;

namespace AdapterPattern
{
    class Program
    {
        static void Main()
        {
            string xmlString = File.ReadAllText("weather-data.xml");
            Console.WriteLine("XML:");
            Console.WriteLine(xmlString);
            Console.WriteLine();

            var adapter = new XmlToJsonAdapter(xmlString);
            adapter.Convert();
            Console.WriteLine("Done!");

            Console.ReadLine();
        }
    }
}
