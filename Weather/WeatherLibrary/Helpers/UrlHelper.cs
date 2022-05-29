using System;

namespace WeatherLibrary.Helpers
{
    public class UrlHelper
    {
        private const string BaseUrlGeolocation = "http://api.positionstack.com/v1/forward";
        private const string BaseUrlWeatherForecast = "https://api.open-meteo.com/v1/forecast";
        private const string BaseUrlTimeZone = "http://api.timezonedb.com/v2.1/get-time-zone";
        private const string WeatherParams = "&hourly=temperature_2m&hourly=relativehumitidy_2m&hourly=dewpoint_2m&hourly=apparent_temperature&hourly=cloudcover&hourly=windspeed_10m&hourly=snow_height&hourly=precipitation";
        private static readonly Lazy<UrlHelper> helper =
            new Lazy<UrlHelper>(() => new UrlHelper());

        public static UrlHelper Instance { get { return helper.Value; } }

        private UrlHelper()
        {

        }
        public string BuildUrlWeather(double latitude, double longitude)
        {
            return $"{BaseUrlWeatherForecast}?latitude={latitude}&longitude={longitude+WeatherParams}";
        }

        public string BuildUrlTimeZone(double latitude, double longitude, string ApiKey)
        {
            return $"{BaseUrlTimeZone}?key={ApiKey}&format=json&by=position&lat={latitude}&lng={longitude}";
        }

        public string BuildUrlGeolocation(string query, string apiKey, string limit = "3")
        {
            return $"{BaseUrlGeolocation}?access_key={apiKey}&query={query}&limit={limit}";
        }
    }
}
