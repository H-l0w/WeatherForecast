using System.ComponentModel;

namespace WeatherLibrary.Enums
{
    public enum WeatherCodes
    {
        [Description("Clear_Sky")]
        ClearSky = 0,

        [Description("Cloudy")]
        MainlyClear = 1,

        [Description("Cloudy")]
        PartlyCloudy = 2,

        [Description("Cloudy")]
        OverCast = 3,

        [Description("Fog")]
        Fog = 45,

        [Description("Fog")]
        RimeFog = 48,

        [Description("Drizzle")]
        LightDrizzle = 51,

        [Description("Drizzle")]
        ModerateDrizzle = 53,

        [Description("Drizzle")]
        IntenseDrizzle = 55,

        [Description("Drizzle")]
        LightFreezingDrizzle = 56,

        [Description("Drizzle")]
        InstenseFreezingDrizzle = 57,

        [Description("Light_Rain")]
        SlightRain = 61,

        [Description("Medium_Rain")]
        ModerateRain = 63,

        [Description("Heavy_Rain")]
        HeavyRain = 65,

        [Description("Freezing_Rain")]
        LightFreezingRain = 66,

        [Description("Freezing_Rain")]
        IntenseFreezingRain = 67,

        [Description("Freezing_Rain")]
        SlightSnowFall = 71,

        [Description("Snowing")]
        ModerateSnowFall = 73,

        [Description("Snowing")]
        HeavySnowFall = 75,

        [Description("Snowing")]
        SnowGrains = 77,

        [Description("Light_Rain")]
        SlightRainShower = 80,

        [Description("Shower")]
        ModerateRainShower = 81,

        [Description("Shower")]
        HeavyRainShower = 82,

        [Description("Shower")]
        LightSnowShower = 85,

        [Description("Snowing")]
        HeavySnowShower = 86,

        [Description("Storm")]
        ThunderStorm = 95,

        [Description("Storm")]
        LightStormWithHails = 96,

        [Description("Storm")]
        HeavyStormWithHails = 99
    }
}
