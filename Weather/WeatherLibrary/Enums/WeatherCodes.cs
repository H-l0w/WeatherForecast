using System.ComponentModel;

namespace WeatherLibrary.Enums
{
    public enum WeatherCodes : int
    {
        [Description("Clear Sky.png")]
        ClearSky = 0,

        [Description("Cloudy.png")]
        MainlyClear = 1,

        [Description("Cloudy.png")]
        PartlyCloudy = 2,

        [Description("Cloudy.png")]
        OverCast = 3,

        [Description("Fog.png")]
        Fog = 45,
        [Description("Fog.png")]
        RimeFog = 48,

        [Description("Drizzle.png")]
        LightDrizzle = 51,

        [Description("Drizzle.png")]
        ModerateDrizzle = 53,

        [Description("Drizzle.png")]
        IntenseDrizzle = 55,

        [Description("Drizzle.png")]
        LightFreezingDrizzle = 56,

        [Description("Drizzle.png")]
        InstenseFreezingDrizzle = 57,

        [Description("Light Rain.png")]
        SlightRain = 61,

        [Description("Medium Rain.png")]
        ModerateRain = 63,

        [Description("Heavy Rain.png")]
        HeavyRain = 65,

        [Description("Freezing Rain.png")]
        LightFreezingRain = 66,

        [Description("Freezing Rain.png")]
        IntenseFreezingRain = 67,

        [Description("Freezing Rain.png")]
        SlightSnowFall = 71,

        [Description("Snowing.png")]
        ModerateSnowFall = 73,

        [Description("Snowing.png")]
        HeavySnowFall = 75,

        [Description("Snowing.png")]
        SnowGrains = 77,

        [Description("Light Rain.png")]
        SlightRainShower = 80,

        [Description("Shower.png")]
        ModerateRainShower = 81,

        [Description("Shower.png")]
        HeavyRainShower = 82,

        [Description("Shower.png")]
        LightSnowShower = 85,

        [Description("Snowing.png")]
        HeavySnowShower = 86,

        [Description("Storm.png")]
        ThunderStorm = 95,

        [Description("Storm.png")]
        LightStormWithHails = 96,

        [Description("Storm.png")]
        HeavyStormWithHails = 99
    }
}
