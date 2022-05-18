using System;
using System.Windows.Forms;
using WeatherLibrary.Helpers;
using WeatherUI.Forms;

namespace WeatherUI
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ConfigHelper.Instance.CreateConfig();
            bool isApiKeyValid = true;
            if (string.IsNullOrEmpty(SessionHelper.Instance.ApiKey))
                isApiKeyValid = false;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (ConfigHelper.Instance.GetLocations().Count > 0) {
                SessionHelper.Instance.Locations = ConfigHelper.Instance.GetLocations();
                Application.Run(new WeatherForm(isApiKeyValid));
            }
            else 
                Application.Run(new LocationForm(true, isApiKeyValid));
        }

    }
}
