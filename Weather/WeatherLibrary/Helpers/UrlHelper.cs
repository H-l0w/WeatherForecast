using System;

namespace WeatherLibrary.Helpers
{
    public class UrlHelper
    {
        private static readonly string BaseUrlGeolocation = "http://api.positionstack.com/v1/forward";
        private static readonly string BaseUrlWeatherForecast = "https://api.open-meteo.com/v1/forecast";
        private static readonly string WeatherParams = "&hourly=temperature_2m&hourly=relativehumitidy_2m&hourly=dewpoint_2m&hourly=apparent_temperature&hourly=cloudcover&hourly=windspeed_10m&hourly=snow_height&hourly=precipitation";
        public static readonly Lazy<UrlHelper> helper =
            new Lazy<UrlHelper>(() => new UrlHelper());

        public static UrlHelper Instance { get { return helper.Value; } }

        private UrlHelper()
        {

        }
        public string BuildUrlWeather(double latitude, double longitude)
        {
            return $"{BaseUrlWeatherForecast}?latitude={latitude.ToString()}&longitude={longitude.ToString()+WeatherParams}";
        }
        public string BuildUrlGeolocation(string query, string apiKey, string limit = "3")
        {
            return $"{BaseUrlGeolocation}?access_key={apiKey}&query={query}&limit={limit}";
        }
    }
}
