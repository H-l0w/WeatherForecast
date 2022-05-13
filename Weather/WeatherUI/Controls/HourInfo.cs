using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WeatherLibrary.Enums;
using WeatherLibrary.Factories;

namespace WeatherUI.Controls
{
    public partial class HourInfo : UserControl
    {
        public WeatherCodes? Code { get; set; }
        public string Time { get; set; }
        public string Value { get; set; }
        private string toolTip;

        public HourInfo()
        {
            InitializeComponent();
        }

        public void HourInfo_Load(object sender, EventArgs e)
        {
            Reload();
            string weather = EnumFactory.GetDescription(Code);

            toolTip = $"Time: {Time} Value: { Value} Weather: {weather.Remove(weather.Length - 4)}";
            
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this, toolTip);
            tip.SetToolTip(pctIcon, toolTip);
            tip.SetToolTip(lblTime, toolTip);
            tip.SetToolTip(lblValue, toolTip);
        }

        public void Reload()
        {
            if (Code == null)
                pctIcon.Image = Image.FromStream(IconFactory.GetIcon("Error.png"));
            else
                pctIcon.Image = Image.FromStream(IconFactory.GetIcon(EnumFactory.GetDescription(Code)));
            lblTime.Text = Time;
            lblValue.Text = Value;
        }
    }
}
