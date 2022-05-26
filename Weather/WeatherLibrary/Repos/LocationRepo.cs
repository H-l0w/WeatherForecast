using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherLibrary.Objects;
using WeatherLibrary.Helpers;

namespace WeatherLibrary.Factories
{
    public class LocationRepo
    {
        public async Task<List<Location>> GetLocations(string location, int limit = 2)
        {
            string url = UrlHelper.Instance.BuildUrlGeolocation(location, SessionHelper.Instance.ApiKeyLocations, limit.ToString());

            string data = await HttpHelper.Instance.SendRequest(url);

            LocationsJson locations = JsonConvert.DeserializeObject<LocationsJson>(data);

            return locations.Locations;
        }
    }
}
