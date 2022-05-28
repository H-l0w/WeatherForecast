using System;
using System.Text;
using System.Windows.Forms;
using WeatherLibrary.Objects;

namespace WeatherUI.Forms
{
    public partial class WeatherDetailForm : FormBase
    {
        private Detail _detail;
        public WeatherDetailForm(Detail detail)
        {
            _detail = detail;
            InitializeComponent();
        }

        private void WeatherDetailForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WeatherDetailForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"{_detail.Name} - {_detail.Time.ToString("dd.MM.yyyy HH:mm")}";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Temperature: {_detail.Temperature}");
            sb.AppendLine($"Apperent temperature: {_detail.ApperentTemperature}");
            sb.AppendLine($"Rain Precipitation: {_detail.RainPrecipitation}");
            sb.AppendLine($"Cloud cover: {_detail.CloudCover}");
            sb.AppendLine($"Wind speed: {_detail.WindSpeed}");
            sb.AppendLine($"Snow height: {_detail.SnowHeight}");
            sb.AppendLine($"Dew point: {_detail.DewPoint}");
            sb.AppendLine($"Humidity: {_detail.Humidity}");
            lblInfo.Text = sb.ToString();
        }

        private void WeatherDetailForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
