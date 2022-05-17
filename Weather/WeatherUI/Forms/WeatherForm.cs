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

        private Point bottomRight;
        private Point bottomLeft;
        private Point topRight;

        private Point topRightForecast;
        private Point topLeftForecast;
        private Point bottomLeftForecast;
        private Point bottomRightForecast;

        Size WeatherForecastFieldSize;
        Size OneWeatherForecastFieldSize;


        private const int EdgePadding = 20;
        private const int ButtonPadding = 10;

        public WeatherForm(List<Location> locations, bool isApiKeyValid = true)
        {
            this.Locations = locations;
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(1280, 720);
            this.isApiKeyValid = isApiKeyValid;
            Task.Run(async () =>
            {
                WeatherForecast = await weatherFactory.GetWeatherForecast(locations[actualLocationIndex]);
            }).GetAwaiter().GetResult();

            InitializeComponent();
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

            ShowWeatherForecast();
            RecalculatePoints();
            AddHourInfo();
            SetToolTips();
            actualDay = WeatherForecast.Info.Times[0].Value.Day;
            UpdateInfoLabel();
            btnPreviousDay.Enabled = false;
            btnPrevious.Enabled = false;
            lblInfo.Location = new Point(topLeftForecast.X, EdgePadding);
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
            int count = 0;
            int x = topLeftForecast.X;
            int y = topLeftForecast.Y;
            foreach (WeatherHourInfo hour in weatherFactory.GetDailyInfo(WeatherForecast, DateTime.Now).HourInfos)
            {
                if (count > 4)
                {
                    x = topLeftForecast.X;
                    count = 0;
                    y += OneWeatherForecastFieldSize.Height;
                }

                HourInfo hourInfo = new HourInfo
                {
                    Code = hour.Code,
                    Time = hour.Time.ToString("HH:mm"),
                    Value = ConversionFactory.ConvertNullableDouble(hour.Temperature) + " °C",
                    Location = new Point(x, y),
                    Width = OneWeatherForecastFieldSize.Width,
                    Height = OneWeatherForecastFieldSize.Height,
                };
                Infos.Add(hourInfo);

                x += OneWeatherForecastFieldSize.Width;
                Controls.Add(hourInfo);
                count++;
            }
            btnChangeData.Location = new Point(x, y);
            btnChangeData.Size = new Size(OneWeatherForecastFieldSize.Width, OneWeatherForecastFieldSize.Height);
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

        private void RepositionControls()
        {
            RecalculatePoints();
            RepositionButtons();
            RepositionWeatherControls();
        }

        private void RecalculatePoints()
        {
            bottomRight = new Point(ClientRectangle.Width, ClientRectangle.Height);
            bottomLeft = new Point(0, ClientRectangle.Height);
            topRight = new Point(ClientRectangle.Width - btnAddNewLocation.Width - EdgePadding, EdgePadding);

            topRightForecast = new Point(topRight.X - btnAddNewLocation.Width, EdgePadding + btnApplicationSettings.Height);
            topLeftForecast = new Point(EdgePadding + btnPrevious.Width + EdgePadding, EdgePadding + btnApplicationSettings.Height);
            bottomLeftForecast = new Point(EdgePadding + btnPrevious.Width, bottomLeft.Y - EdgePadding);
            bottomRightForecast = new Point(btnPrevious.Width, bottomLeft.Y - EdgePadding);

            WeatherForecastFieldSize = new Size(topRightForecast.X - topLeftForecast.Y, bottomRightForecast.Y - topRightForecast.Y);
            OneWeatherForecastFieldSize = new Size(WeatherForecastFieldSize.Width / 5, WeatherForecastFieldSize.Height / 5);
        }

        private void RepositionWeatherControls()
        {
            int count = 0;
            int x = topLeftForecast.X;
            int y = topLeftForecast.Y;
            foreach (HourInfo info in Infos){

                if (count > 4)
                {
                    count = 0;
                    y += OneWeatherForecastFieldSize.Height;
                    x = topLeftForecast.X;
                }
                info.Location = new Point(x, y);
                info.Width = OneWeatherForecastFieldSize.Width;
                info.Height = OneWeatherForecastFieldSize.Height;
                x += OneWeatherForecastFieldSize.Width;
                info.SetControls();
                count++;
            }
            btnChangeData.Location = new Point(x, y);
            btnChangeData.Size = new Size(OneWeatherForecastFieldSize.Width, OneWeatherForecastFieldSize.Height);
        }

        private void RepositionButtons()
        {
            btnAddNewLocation.Location = new Point(bottomRight.X - btnAddNewLocation.Width - EdgePadding, EdgePadding);

            btnApplicationSettings.Location = new Point(bottomRight.X - btnApplicationSettings.Width - EdgePadding,
                                                        EdgePadding + btnAddNewLocation.Height + ButtonPadding);

            btnPrevious.Location = new Point(EdgePadding, bottomLeft.Y - EdgePadding - btnPrevious.Height);

            btnPreviousDay.Location = new Point(EdgePadding,
                                                bottomLeft.Y - EdgePadding - btnPrevious.Height - btnPrevious.Height - ButtonPadding);

            btnNext.Location = new Point(bottomRight.X - btnNext.Width - EdgePadding,
                                         bottomRight.Y - btnNext.Height - EdgePadding);

            btnNextDay.Location = new Point(bottomRight.X - btnNextDay.Width - EdgePadding,
                                         bottomRight.Y - btnNextDay.Height - ButtonPadding - btnNext.Height - EdgePadding);
        }

        private void WeatherForm_Resize(object sender, EventArgs e)
        {
            RepositionControls();
        }
    }
}
