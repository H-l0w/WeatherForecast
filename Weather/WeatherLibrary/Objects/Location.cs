using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Number")]
        public int? Number { get; set; }

        [JsonProperty("PostalCode")]
        public int? PostalCode { get; set; }

        [JsonProperty("Street")]
        public string Street { get; set; }

        [JsonProperty("Confidence")]
        public double? Confidence { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("County")]
        public string County { get; set; }

        [JsonProperty("Locality")]
        public string Locality { get; set; }

        [JsonProperty("AdministrativeArea")]
        public string AdministrativeArea { get; set; }

        [JsonProperty("Neighbourhood")]
        public string Neighbourhood { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("Continent")]
        public string Continent { get; set; }

        [JsonProperty("Label")]
        public string Label { get; set; }
    }
}
