using System;
using System.Collections.Generic;
using WeatherLibrary.Objects;
using WeatherLibrary.Enums;

namespace WeatherLibrary.Factories
{
    public class MockFactory
    {
        public WeatherForecast GetWeatherForecastMock()
        {
            Info info = new Info();

            WeatherForecast weatherForecast = new WeatherForecast();
            weatherForecast.GenerationTimeMs = 0;
            weatherForecast.Elevation = 1337;

            info.Times = GetDateTimeList();
            info.ApperentTemperatures = GetDoubleList();
            info.Precipitations = GetDoubleList();
            info.Cloudcovers = GetIntList();
            info.WindSpeeds = GetDoubleList();
            info.SnowHeights = GetDoubleList();
            info.Temperatures = GetDoubleList();
            info.Dewpoints = GetDoubleList();
            info.Humidities = GetIntList();
            info.WeatherCodes = GetWeatherCodesList();
            
            weatherForecast.Info = info;

            return weatherForecast;

        }

        private List<double?> GetDoubleList()
        {
            int count = 0;
            List<double?> doubles = new List<double?>();

            while (count != 23)
            {
                doubles.Add(new Random().NextDouble() * 30);
                count++;
            }

            return doubles;
        }

        private List<int?> GetIntList()
        {
            int count = 0;
            List<int?> ints = new List<int?>();

            while (count != 23)
            {
                ints.Add(new Random().Next(1, 30));
                count++;
            }
            return ints;
        }

        private List<WeatherCodes?> GetWeatherCodesList()
        {
            int[] codes = { 0, 1, 2, 3, 45, 48, 51, 53, 55, 56, 57, 61, 63, 65, 66, 67, 71, 73, 75, 77, 80, 81, 82, 85, 86, 95, 96, 99 };
            int count = 0;
            List<WeatherCodes?> weatherCodes = new List<WeatherCodes?>();
            while (count != 23)
            {
                weatherCodes.Add((WeatherCodes?)codes[new Random().Next(0, 28)]);
                count++;
            }
            return weatherCodes;
        }

        private List<DateTime?> GetDateTimeList()
        {
            int hour = 0;
            List<DateTime?> dateTimes = new List<DateTime?>();

            while (hour != 23)
            {
                DateTime time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, 0, 0);
                dateTimes.Add(time);
                hour++;
            }

            return dateTimes;
        }
    }
}
