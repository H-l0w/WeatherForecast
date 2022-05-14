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
            if (ConfigHelper.Instance.GetLocations().Count > 0)
                Application.Run(new WeatherForm(ConfigHelper.Instance.GetLocations(), isApiKeyValid));
            else 
                Application.Run(new LocationForm(true, isApiKeyValid));
        }

    }
}
