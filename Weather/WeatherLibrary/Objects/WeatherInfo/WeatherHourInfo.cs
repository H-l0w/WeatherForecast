using System;
using WeatherLibrary.Enums;

namespace WeatherLibrary.Objects.WeatherInfo
{
    public class WeatherHourInfo
    {
        public DateTime Time { get; set; }
        public WeatherCodes? Code { get; set; }
        public double? ApperentTemperature { get; set; }
        public double? RainPrecipitation { get; set; }
        public double? CloudCover { get; set; }
        public double? WindSpeed { get; set; }
        public double? SnowHeight { get; set; }
        public double? Temperature { get; set; }
        public double? DewPoint { get; set; }
        public int? Humidity { get; set; }
    }
}
