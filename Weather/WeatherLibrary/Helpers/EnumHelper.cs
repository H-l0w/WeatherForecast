using System;
using System.ComponentModel;
using WeatherLibrary.Enums;

namespace WeatherLibrary.Factories
{
    public class EnumHelper
    {
        public static string GetDescription(Enum enumValue)
        {
            if (enumValue != null)
            {
                var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

                var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
                return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
            }
            return "Error.png";
        }

        public static string GetUnit(Enum enumValue)
        {
            if (enumValue == null)
                return string.Empty;

            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            var details = (WeatherDetail[])fieldInfo.GetCustomAttributes(typeof(WeatherDetail), false);
            return details.Length > 0 ? details[0].Unit : enumValue.ToString();
        }
    }
}
