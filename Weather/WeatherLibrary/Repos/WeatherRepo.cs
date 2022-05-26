using System;
using System.Threading.Tasks;
using WeatherLibrary.Objects;
using Newtonsoft.Json;
using System.Collections.Generic;
using WeatherLibrary.Helpers;
using WeatherLibrary.Objects.WeatherInfo;

namespace WeatherLibrary.Factories
{
    public class WeatherRepo
    {
        public async Task<WeatherForecast> GetWeatherForecast(Location location)
        {
            string url = UrlHelper.Instance.BuildUrlWeather(Math.Round(location.Latitude,3), Math.Round(location.Longitude, 3));

            url = url.Replace(',', '.');

            url += ",weathercode";

            string data = await HttpHelper.Instance.SendRequest(url);

            WeatherForecast weatherForecast = JsonConvert.DeserializeObject<WeatherForecast>(data);

            return weatherForecast;
        }

        private WeatherHourInfo GetHourInfo(WeatherForecast forecast, DateTime time)
        {
            int actualInfo = 0;
            DateTime end;
            foreach (DateTime dateTime in forecast.Info.Times)
            {
                if (dateTime.Hour == 23)
                    end = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, dateTime.Minute, dateTime.Second);
                else
                    end = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour + 1, dateTime.Minute, dateTime.Second);

                if ((time >= dateTime) && (time <= end))
                {
                    WeatherHourInfo info = new WeatherHourInfo();

                    info.ApperentTemperature = forecast.Info.ApperentTemperatures[actualInfo];
                    info.RainPrecipitation = forecast.Info.Precipitations[actualInfo];
                    info.CloudCover = forecast.Info.Cloudcovers[actualInfo];
                    info.WindSpeed = forecast.Info.WindSpeeds[actualInfo];
                    info.SnowHeight = forecast.Info.SnowHeights[actualInfo];
                    info.Temperature = forecast.Info.Temperatures[actualInfo];
                    info.DewPoint = forecast.Info.Dewpoints[actualInfo];
                    info.Humidity = forecast.Info.Humidities[actualInfo];
                    info.Time = time;
                    info.Code = forecast.Info.WeatherCodes[actualInfo];

                    return info;
                }
                actualInfo++;
            }
            throw new ArgumentException();
        }

        public WeatherDailyInfo GetDailyInfo(WeatherForecast forecast ,DateTime time)
        {
            DateTime date = new DateTime();
            List<WeatherHourInfo> infos = new List<WeatherHourInfo>();
            for (int i = 0; i < 24; i++)
            {
                date = new DateTime(time.Year, time.Month, time.Day, i, 0, 0);
                WeatherHourInfo info = GetHourInfo(forecast, date);
                infos.Add(info);
            }
            WeatherDailyInfo dailyInfo = new WeatherDailyInfo();
            dailyInfo.Time = date;
            dailyInfo.HourInfos = infos;
            return dailyInfo;
        }
    }
}
