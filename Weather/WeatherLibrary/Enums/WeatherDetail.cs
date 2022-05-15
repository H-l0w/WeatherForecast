using System.ComponentModel;

namespace WeatherLibrary.Enums
{
    public class WeatherDetail : DescriptionAttribute
    {
        public string Unit { get; set; }

        public WeatherDetail(string description, string unit) : base(description)
        {
            Unit = unit;
        }
    }
}
