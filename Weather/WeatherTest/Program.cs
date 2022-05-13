using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherLibrary.Objects;
using WeatherLibrary;
using Newtonsoft.Json;
using System.Collections.Generic;
using WeatherLibrary.Factories;

namespace WeatherTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () =>
            {
            }).GetAwaiter().GetResult();
        }

        private static void testGetIcons()
        {
            IconFactory.GetIcons();
        }
        private async static Task TestWeatherForecastApi()
        {
            LocationFactory locationFactory = new LocationFactory();
            WeatherFactory weatherForecastFactory = new WeatherFactory();
            List<Location> locations = await locationFactory.GetLocations("Liberec");



            WeatherForecast forecast = await weatherForecastFactory.GetWeatherForecast(locations[0]);
        }

        private async static void TestLocationApi()
        {
            LocationFactory factory = new LocationFactory();
            List<Location> locations = await factory.GetLocations("Liberec");

            foreach (Location location in locations)
            {
                Console.WriteLine(location.Latitude);
                Console.WriteLine(location.Longitude);
            }
        }
    }
}
