using System;

namespace WeatherLibrary.Factories
{
    public static class ConversionFactory
    {
        public static string ConvertNullableDouble(double? value)
        {
            double result;

            if (value.HasValue)
            {
                result = Math.Round(value.Value, 1);
                return result.ToString();
            }
            return string.Empty;
        }
    }
}
