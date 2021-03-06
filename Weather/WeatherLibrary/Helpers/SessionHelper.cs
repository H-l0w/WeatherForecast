using System;
using System.Collections.Generic;
using System.Drawing;
using WeatherLibrary.Objects;

namespace WeatherLibrary.Helpers
{
    public class SessionHelper
    {
        private static readonly Lazy<SessionHelper> helper =
        new Lazy<SessionHelper>(() => new SessionHelper());

        public static SessionHelper Instance { get { return helper.Value; } }

        private SessionHelper()
        {
            Background = ConfigHelper.Instance.GetColor();
            Locations = new List<Location>();
            Locations.AddRange(ConfigHelper.Instance.GetLocations());
            ApiKeyLocations = ConfigHelper.Instance.GetApiKey("API Key - Locations");
            ApiKeyTimeZone = ConfigHelper.Instance.GetApiKey("API Key - Timezone");
        }
        public Color Background { get; set; }
        public List<Location> Locations { get; set; }
        public string ApiKeyLocations { get; set; }
        public string ApiKeyTimeZone { get; set; }
    }
}
