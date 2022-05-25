namespace WeatherLibrary.Enums
{
    public enum Data
    {
        [WeatherDetail("Temperature", "°C")]
        Temperature = 0,

        [WeatherDetail("Apperent temperature", "°C")]
        ApperentTemperature = 1,

        [WeatherDetail("Precipitation", "mm")]
        RainPrecipitation = 2,

        [WeatherDetail("Cloud cover", "%")]
        CloudCover = 3,

        [WeatherDetail("Wind speed", "Km/s")]
        WindSpeed = 4,

        [WeatherDetail("Snow height", "m")]
        SnowHeight = 5,

        [WeatherDetail("Dewpoint", "°C")]
        DewPoint = 6,

        [WeatherDetail("Relative humidity", "%")]
        Humidity = 7
    }
}
