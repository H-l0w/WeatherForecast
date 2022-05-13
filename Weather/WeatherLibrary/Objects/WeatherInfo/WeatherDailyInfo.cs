using System;
using System.Collections.Generic;

namespace WeatherLibrary.Objects.WeatherInfo
{
    public class WeatherDailyInfo
    {
        public DateTime Time { get; set; }
        public List<WeatherHourInfo> HourInfos { get; set; }
    }
}
