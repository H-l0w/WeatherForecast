using System;
using System.ComponentModel;

namespace WeatherLibrary.Factories
{
    public class EnumFactory
    {
        public static string GetDescription(Enum enumValue)
        {
            if (enumValue != null)
            {
                var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

                var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

                return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
            }
            return "Error.png";
        }
    }
}
