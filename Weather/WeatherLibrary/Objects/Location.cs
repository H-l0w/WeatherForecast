using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherLibrary.Objects
{

    public partial class LocationsJson
    {
        [JsonProperty("data")]
        public List<Location> Locations { get; set; }
    }

    public class Location
    {
        [JsonProperty("Latitude")]
        public float Latitude { get; set; }

        [JsonProperty("Longitude")]
        public float Longitude { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("Continent")]
        public string Continent { get; set; }

        public virtual int TimeOffset { get; set; }
        public virtual bool IsTimeZoneSet { get; set; }
    }
}
