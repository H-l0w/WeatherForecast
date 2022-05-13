using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using WeatherLibrary.Factories;
using WeatherLibrary.Objects;
using WeatherUI.Controls;
using WeatherLibrary.Enums;
using WeatherLibrary.Objects.WeatherInfo;
using WeatherLibrary.Helpers;
using System.Globalization;

namespace WeatherUI.Forms                                                                                                         
{
    public partial class WeatherForm : FormBase
    {
        private List<Location> Locations { get; set; }
        private WeatherForecast WeatherForecast { get; set; }
        private int actualLocationIndex = 0; 
        private readonly WeatherFactory weatherFactory = new WeatherFactory();
        private List<HourInfo> Infos = new List<HourInfo>();
        private Data DataEnum = Data.Temperature;
        private int actualDay;
        public WeatherForm(List<Location> locations)
        {
            this.Locations = locations;
            Task.Run(async () =>
            {
                WeatherForecast = await weatherFactory.GetWeatherForecast(locations[actualLocationIndex]);
            }).GetAwaiter().GetResult();
            InitializeComponent();
            showWeatherForecast();
            addHourInfo();
            actualDay = WeatherForecast.Info.Times[0].Value.Day;
            updateInfoLabel();
            btnPreviousDay.Enabled = false;
            btnPrevious.Enabled = false;
            if (locations.Count == 0)
                btnNext.Enabled = false;
        }

        private void btnApplicationSettings_Click(object sender, EventArgs e)
        {
            ApplicationSettingsForm form = new ApplicationSettingsForm();
            form.Show();
        }

        private void btnAddNewLocation_Click(object sender, EventArgs e)
        {
            LocationForm form = new LocationForm(false);
            var result = form.ShowDialog();

            if(result == DialogResult.OK)
            {
                Locations.Add(form.SelectedLocation);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            actualLocationIndex--;

            if (actualLocationIndex <= 0)
                btnPrevious.Enabled = false;
            if (actualLocationIndex != -1)
            {
                Task.Run(async () => WeatherForecast = await weatherFactory.GetWeatherForecast(Locations[actualLocationIndex])).GetAwaiter().GetResult();
                showWeatherForecast();
                changeHourInfo(DateTime.Now);
            }

            updateInfoLabel();

            if (actualLocationIndex < Locations.Count)
                btnNext.Enabled = true;
        }

        private void updateInfoLabel()
        {
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, actualDay);
            CultureInfo info = new CultureInfo("en");
            string day = info.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
            lblInfo.Text = $"{EnumFactory.GetDescription(DataEnum)} for location {Locations[actualLocationIndex].Name} | Date: {date.ToString("dd.MM.yyyy")} - {day}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            actualLocationIndex++;
            updateInfoLabel();

            if (actualLocationIndex >= Locations.Count - 1)
                btnNext.Enabled = false;

            if (actualLocationIndex >= 0 && actualLocationIndex < Locations.Count)
            {
                showWeatherForecast();
                Task.Run(async () => WeatherForecast = await weatherFactory.GetWeatherForecast(Locations[actualLocationIndex])).GetAwaiter().GetResult();
            }

            updateInfoLabel();

            if (actualLocationIndex != 0)
                btnPrevious.Enabled = true;
        }

        private void showWeatherForecast()
        {
            lblLocationDetails.Text = $"Location details - {Locations[actualLocationIndex].Name}";
            lblLatitude.Text = "Latitude: " + Locations[actualLocationIndex].Latitude.ToString();
            LblLongitude.Text = "Longitude: " + Locations[actualLocationIndex].Longitude.ToString();
            lblRegion.Text = "Location: " + Locations[actualLocationIndex].Region;
            lblCountry.Text = "Country: " + Locations[actualLocationIndex].Country;
            lblContinent.Text = "Continent: " + Locations[actualLocationIndex].Continent;
            lblElevation.Text = "Elevation: " + WeatherForecast.Elevation.ToString() + "m";
        }

        private void changeHourInfo(DateTime dateTime)
        {
            string value = string.Empty;
            string time = string.Empty;
            int index = 0;

            foreach (WeatherHourInfo hour in weatherFactory.GetDailyInfo(WeatherForecast, dateTime).HourInfos)
            {
                switch (DataEnum)
                {
                    case Data.Temperature:
                        value = ConversionFactory.ConvertNullableDouble(hour.Temperature) + " °C";
                        break;
                    case Data.ApperentTemperature:
                        value = ConversionFactory.ConvertNullableDouble(hour.ApperentTemperature) + " °C";
                        break;
                    case Data.CloudCover:
                        value = $"{hour.CloudCover} %";
                        break;
                    case Data.WindSpeed:
                        value = ConversionFactory.ConvertNullableDouble(hour.WindSpeed) + "Km/s";
                        break;
                    case Data.SnowHeight:
                        value = ConversionFactory.ConvertNullableDouble(hour.SnowHeight) + "m";
                        break;
                    case Data.Dewpoint:
                        value = ConversionFactory.ConvertNullableDouble(hour.DewPoint) + " °C";
                        break;
                    case Data.RelatievHumidity:
                        value = $"{hour.Humidity} %";
                        break;
                    case Data.Precipitation:
                        value = $"{hour.RainPrecipitation} mm";
                        break;
;                    default:
                        break;
                }

                time = hour.Time.ToString("HH:mm");
                Infos[index].Time = time;
                Infos[index].Value = value;
                Infos[index].Reload();
                index++;
            }
        }

        private void addHourInfo()
        {
            int y = 179;
            int x = 142;
            int count = 0;
            foreach (WeatherHourInfo hour in weatherFactory.GetDailyInfo(WeatherForecast, DateTime.Now).HourInfos)
            {
                if (count > 4)
                {
                    x = 142;
                    count = 0;
                    y += 76;
                }

                HourInfo hourInfo = new HourInfo
                {
                    Code = hour.Code,
                    Time = hour.Time.ToString("HH:mm"),
                    Value = ConversionFactory.ConvertNullableDouble(hour.Temperature) + " °C",
                    Location = new Point(x, y)
                };
                Infos.Add(hourInfo);

                x += 150;
                Controls.Add(hourInfo);
                count++;
            }
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            ChangeDataForm form = new ChangeDataForm(DataEnum);
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                DataEnum = form.DataEnum;
                changeHourInfo(DateTime.Now);
                updateInfoLabel();
            }
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            actualDay++;
            changeHourInfo(new DateTime(DateTime.Now.Year, DateTime.Now.Month, actualDay));
            updateInfoLabel();
            btnPreviousDay.Enabled = true;

            if (actualDay - DateTime.Now.Day > 5)
                btnNextDay.Enabled = false;
        }

        private void bntPreviousDay_Click(object sender, EventArgs e)
        {
            actualDay--;
            changeHourInfo(new DateTime(DateTime.Now.Year, DateTime.Now.Month, actualDay));
            updateInfoLabel();
            btnNextDay.Enabled = true;

            if (actualDay - DateTime.Now.Day == 0)
                btnPreviousDay.Enabled = false;
        }

        private void btnSavedLocationsManager_Click(object sender, EventArgs e)
        {
            SavedLocationsForm form = new SavedLocationsForm();
            form.ShowDialog();

            Locations = ConfigHelper.Instance.GetLocations();

            if (Locations.Count == 0)
                closeThisAndOpenLocation();
        }

        private void closeThisAndOpenLocation()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.Hide();
                LocationForm form = new LocationForm(true);
                form.Closed += (s, args) => this.Close();
                form.Show();
            });
        }
    }
}
