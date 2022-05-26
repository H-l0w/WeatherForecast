using System;

namespace WeatherLibrary.Factories
{
    public static class ConversionHelper
    {
        public static string ConvertNullableDouble(double? value)
        {
            if (value.HasValue)
            {
                double result = Math.Round(value.Value, 1);
                return result.ToString();
            }
            return string.Empty;
        }
    }
}
