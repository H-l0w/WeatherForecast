using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherLibrary.Objects;
using WeatherLibrary.Helpers;

namespace WeatherLibrary.Factories
{
    public class LocationFactory
    {
        public async Task<List<Location>> GetLocations(string location, int limit = 2)
        {
            string url = UrlHelper.Instance.BuildUrlGeolocation(location, SessionHelper.Instance.ApiKey, limit.ToString());

            string data = await HttpHelper.Instance.SendRequest(url);

            LocationsJson locations = JsonConvert.DeserializeObject<LocationsJson>(data);

            return locations.Locations;
        }
    }
}
