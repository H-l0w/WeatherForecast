using System;

namespace WeatherLibrary.Objects
{
    public class Detail
    {
        public double Temperature { get; set; }
        public double ApperentTemperature { get; set; }
        public double RainPrecipitation { get; set; }
        public double CloudCover { get; set; }
        public double WindSpeed { get; set; }
        public double SnowHeight { get; set; }
        public double DewPoint { get; set; }
        public int Humidity { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
    }
}
