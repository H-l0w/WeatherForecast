using System.ComponentModel;

namespace WeatherLibrary.Enums
{
    public enum Data
    {
        [Description("Temperature")]
        Temperature = 0,

        [Description("Apperent temperature")]
        ApperentTemperature = 1,

        [Description("Precipitation")]
        Precipitation = 2,

        [Description("Cloud cover")]
        CloudCover = 3,

        [Description("Wind speed")]
        WindSpeed = 4,

        [Description("Snow height")]
        SnowHeight = 5,

        [Description("Dewpoint")]
        Dewpoint = 6,

        [Description("Relative humidity")]
        RelatievHumidity = 7
    }
}
