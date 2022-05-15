using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using WeatherLibrary.Factories;
using WeatherLibrary.Objects;
using WeatherUI.Controls;
using WeatherLibrary.Enums;
using WeatherLibrary.Objects.WeatherInfo;
using System.Globalization;
using System.Linq;

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
        private bool isApiKeyValid;
        public WeatherForm(List<Location> locations, bool isApiKeyValid = true)
        {
            this.Locations = locations;
            this.isApiKeyValid = isApiKeyValid;
            Task.Run(async () =>
            {
                WeatherForecast = await weatherFactory.GetWeatherForecast(locations[actualLocationIndex]);
            }).GetAwaiter().GetResult();
            InitializeComponent();
            ShowWeatherForecast();
            AddHourInfo();
            SetToolTips();
            actualDay = WeatherForecast.Info.Times[0].Value.Day;
            UpdateInfoLabel();
            btnPreviousDay.Enabled = false;
            btnPrevious.Enabled = false;
            if (locations.Count == 1)
                btnNext.Enabled = false;
        }

        private void SetToolTips()
        {
            if (actualLocationIndex != 0)
                btnNextPreviousToolTip.SetToolTip(btnPrevious, Locations[actualLocationIndex -1].Name);
            if (actualLocationIndex != Locations.Count - 1)
                btnNextPreviousToolTip.SetToolTip(btnNext, Locations[actualLocationIndex +1].Name);
        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {
            if (!isApiKeyValid)
                MessageBox.Show("Api key is not, please edit it in config file");
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
                if (Locations.Count > 1)
                    btnNext.Enabled = true; 
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
                ShowWeatherForecast();
                ChangeHourInfo(DateTime.Now);
            }

            UpdateInfoLabel();
            SetToolTips();

            if (actualLocationIndex < Locations.Count)
                btnNext.Enabled = true;
        }

        private void UpdateInfoLabel()
        {
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, actualDay);
            CultureInfo info = new CultureInfo("en");
            string day = info.DateTimeFormat.GetDayName(date.DayOfWeek);
            lblInfo.Text = $"{EnumFactory.GetDescription(DataEnum)} for location {Locations[actualLocationIndex].Name} | Date: {date.ToString("dd.MM.yyyy")} - {day}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            actualLocationIndex++;
            UpdateInfoLabel();

            if (actualLocationIndex >= Locations.Count - 1)
                btnNext.Enabled = false;

            if (actualLocationIndex >= 0 && actualLocationIndex < Locations.Count)
            {
                ShowWeatherForecast();
                Task.Run(async () => WeatherForecast = await weatherFactory.GetWeatherForecast(Locations[actualLocationIndex])).GetAwaiter().GetResult();
            }

            UpdateInfoLabel();
            SetToolTips();

            if (actualLocationIndex != 0)
                btnPrevious.Enabled = true;
        }

        private void ShowWeatherForecast()
        {
            lblLocationDetails.Text = $"Location details - {Locations[actualLocationIndex].Name}";
            lblLatitude.Text = "Latitude: " + Locations[actualLocationIndex].Latitude.ToString();
            LblLongitude.Text = "Longitude: " + Locations[actualLocationIndex].Longitude.ToString();
            lblRegion.Text = "Location: " + Locations[actualLocationIndex].Region;
            lblCountry.Text = "Country: " + Locations[actualLocationIndex].Country;
            lblContinent.Text = "Continent: " + Locations[actualLocationIndex].Continent;
            lblElevation.Text = "Elevation: " + WeatherForecast.Elevation.ToString() + "m";
        }

        private void ChangeHourInfo(DateTime dateTime)
        {
            string value = string.Empty;
            string time = string.Empty;
            int index = 0;

            foreach (WeatherHourInfo hour in weatherFactory.GetDailyInfo(WeatherForecast, dateTime).HourInfos)
            {
                value = hour.GetType().GetProperty(DataEnum.ToString()).GetValue(hour).ToString() + EnumFactory.GetUnit(DataEnum);

                time = hour.Time.ToString("HH:mm");
                Infos[index].Time = time;
                Infos[index].Value = value;
                Infos[index].Reload();
                index++;
            }
        }

        private void AddHourInfo()
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
                ChangeHourInfo(DateTime.Now);
                UpdateInfoLabel();
            }
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            actualDay++;
            ChangeHourInfo(new DateTime(DateTime.Now.Year, DateTime.Now.Month, actualDay));
            UpdateInfoLabel();
            btnPreviousDay.Enabled = true;

            if (actualDay - DateTime.Now.Day > 5)
                btnNextDay.Enabled = false;
        }

        private void bntPreviousDay_Click(object sender, EventArgs e)
        {
            actualDay--;
            ChangeHourInfo(new DateTime(DateTime.Now.Year, DateTime.Now.Month, actualDay));
            UpdateInfoLabel();
            btnNextDay.Enabled = true;

            if (actualDay - DateTime.Now.Day == 0)
                btnPreviousDay.Enabled = false;
        }
    }
}
