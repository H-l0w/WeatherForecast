using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WeatherLibrary.Enums;

namespace WeatherLibrary.Objects
{
    public class WeatherForecast
    {
        [JsonProperty("generationtime_ms")]
        public double GenerationTimeMs { get; set; }

        [JsonProperty("hourly")]
        public Info Info { get; set; }

        [JsonProperty("elevation")]
        public double Elevation { get; set; }
    }

    public partial class Info
    {
        [JsonProperty("time")]
        public List<DateTime?> Times { get; set; }

        [JsonProperty("apparent_temperature")]
        public List<double?> ApperentTemperatures { get; set; }

        [JsonProperty("precipitation")]
        public List<double?> Precipitations { get; set; }

        [JsonProperty("cloudcover")]
        public List<int?> Cloudcovers { get; set; }

        [JsonProperty("windspeed_10m")]
        public List<double?> WindSpeeds { get; set; }

        [JsonProperty("snow_height")]
        public List<double?> SnowHeights { get; set; }

        [JsonProperty("temperature_2m")]
        public List<double?> Temperatures { get; set; }

        [JsonProperty("dewpoint_2m")]
        public List<double?> Dewpoints { get; set; }

        [JsonProperty("relativehumitidy_2m")]
        public List<int?> Humidities { get; set; }

        [JsonProperty("weathercode")]
        public List<WeatherCodes?> WeatherCodes { get; set; }
    }

}
