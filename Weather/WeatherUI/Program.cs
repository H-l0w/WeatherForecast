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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (ConfigHelper.Instance.GetLocations().Count > 0)
                Application.Run(new WeatherForm (ConfigHelper.Instance.GetLocations()));
            else 
                Application.Run(new LocationForm(true));
        }

    }
}
