using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using WeatherLibrary.Objects;

namespace WeatherLibrary.Helpers
{
    public class ConfigHelper
    {
        private static readonly Lazy<ConfigHelper> helper =
        new Lazy<ConfigHelper>(() => new ConfigHelper());

        public static ConfigHelper Instance { get { return helper.Value; } }

        private ConfigHelper() { }

        public readonly string dirName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Weather\");
        private static readonly string locatationsFile = "Locations.cfg";
        public readonly string appSettingsFile = "AppSettings.cfg";

        public void CreateConfig()
        {
            if (!Directory.Exists(dirName))
                Directory.CreateDirectory(dirName);

            if (!File.Exists(dirName + locatationsFile))
                File.Create(dirName + locatationsFile).Close();

            if (!File.Exists(dirName + appSettingsFile)) {
                File.Create(dirName + appSettingsFile).Close();
                WriteDefaultValues();
            }
        }

        private List<string> ReadConfig(string filePath)
        {
            return File.ReadAllLines(filePath).ToList();
        }

        public List<Location> GetLocations()
        {
            List<Location> locations = new List<Location>();

            foreach (string line in ReadConfig(dirName + locatationsFile)) {
                Location temp = GetLocationFromString(line);
                if (temp != null)
                    locations.Add(temp);
            }

            return locations;
        }

        private void WriteDefaultValues()
        {
            SaveConfig(dirName + appSettingsFile, "Background:255;255;255;255;", false);
            SaveConfig(dirName + appSettingsFile, "API Key - Locations: \"\"", true);
            SaveConfig(dirName + appSettingsFile, "API Key - Timezone: \"\"", true);
        }

        private Color GetColorFromString(string color)
        {
            string[] split = color.Split(';');
            string[] splitName = split[0].Split(':');
            return Color.FromArgb(Convert.ToInt32(splitName[1]), Convert.ToInt32(split[1]), 
                Convert.ToInt32(split[2]), Convert.ToInt32(split[3]));
        }

        private Location GetLocationFromString(string locationString)
        {
            if (string.IsNullOrEmpty(locationString))
                return null;
            Location location = new Location();
            string[] split = locationString.Split(';');
            PropertyInfo[] props = typeof(Location).GetProperties();
            for (int i = 0; i < split.Length; i++) {
                if (i == props.Length)
                    return location;

                var converted = Convert.ChangeType(split[i], props[i].PropertyType);
                props[i].SetValue(location, converted);
            }
            return location;
        }

        private string ConverToString(List<string> lines)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string line in lines) {
                sb.AppendLine(line);
            }
            return sb.ToString();
        }

        public Color GetColor()
        {
            List<string> lines = ReadConfig(dirName + appSettingsFile);
            foreach (string line in lines) {
                if (line.Contains("Background")) {
                    Color color = GetColorFromString(line);
                    return GetColorFromString(line);
                }
            }
            return Color.FromArgb(255, 255, 255, 255);
        }

        public void AddColorTheme(Color color)
        {
            List<string> lines = ReadConfig(dirName + appSettingsFile);

            for (int i = 0; i < lines.Count; i++) {
                if (lines[i].Contains("Background:")) {
                    lines.RemoveAt(i);
                    lines.Add($"Background:{color.A};{color.R};{color.G};{color.B};");
                }
            }
            SaveConfig(dirName + appSettingsFile, ConverToString(lines), false);
        }

        public void SaveConfig(string filePath, string content, bool append)
        {
            using (StreamWriter sw = new StreamWriter(filePath, append)) {
                sw.WriteLine(content);
                if (sw != null)
                    sw.Dispose();
            }
        }

        public void EditConfig(string filePath, string lineName, string newLine)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            lines.Remove(lines.FirstOrDefault(l => l.Contains(lineName)));
            lines.Add(newLine);

            File.WriteAllLines(filePath, lines);
        }

        public void SaveLocation(Location location, bool append)
        {
            string locationSerialize = $"{location.Latitude};{location.Longitude};{location.Name ?? string.Empty};{location.Continent ?? string.Empty};{location.Country ?? string.Empty};{location.Region ?? string.Empty};{location.TimeOffset};{location.IsTimeZoneSet};";
            SaveConfig(dirName + locatationsFile, locationSerialize, append);
        }

        public void RemoveLocation(int index)
        {
            List<Location> locations = GetLocations();
            locations.RemoveAt(index);

            bool append = false;

            if (locations.Count == 0)
                SaveConfig(dirName + locatationsFile, string.Empty, false);

            foreach (Location location in locations) {
                SaveLocation(location, append);
                append = true;
            }
        }

        public string GetApiKey(string name)
        {
            List<string> lines = ReadConfig(dirName + appSettingsFile);
            string line = lines.FirstOrDefault(l => l.Contains(name));
            string apiKey = line.Split(':')[1];
            apiKey = apiKey.Replace('"', ' ').Trim();
            return apiKey;
        }
    }
}
