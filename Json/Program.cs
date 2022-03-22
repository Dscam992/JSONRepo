using System;
using System.Text.Json;
using static System.Console;

namespace Json
{
    public class Program
    {

        public class WeatherForecast
        {
            public DateTimeOffset Date { get; set; }
            public int TemperatureCelsius { get; set; }
            public string Summary { get; set; }
        }
        public static void Main()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };
            var phoenixForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2022-03-22"),
                TemperatureCelsius = 28,
                Summary = "Warm"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);
            WriteLine(jsonString);

            string phoenixString = JsonSerializer.Serialize(phoenixForecast);
            WriteLine(phoenixString);

            WeatherForecast w = JsonSerializer.Deserialize<WeatherForecast>(phoenixString);
            WriteLine(w.Summary);
            ReadKey();
        }
    }
}

