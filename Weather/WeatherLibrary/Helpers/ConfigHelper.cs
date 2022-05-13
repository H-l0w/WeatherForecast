using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using WeatherLibrary.Objects;

namespace WeatherLibrary.Helpers
{
    public class ConfigHelper
    {
        private static readonly Lazy<ConfigHelper> helper =
        new Lazy<ConfigHelper>(() => new ConfigHelper());

        public static ConfigHelper Instance { get { return helper.Value; } }

        private ConfigHelper(){ }

        private static readonly string dirName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Weather\");
        private static readonly string locatationsFile = "Locations.cfg";
        private static readonly string appSettingsFile = "AppSettings.cfg";

        public void CreateConfig()
        {
            if (!Directory.Exists(dirName))
                Directory.CreateDirectory(dirName);
            if (!File.Exists(dirName + locatationsFile)) 
                File.Create(dirName + locatationsFile).Close();
            if (!File.Exists(dirName + appSettingsFile))
            {
                File.Create(dirName + appSettingsFile).Close();
                WriteDefaultValues();
            }
            if (!Directory.Exists(dirName + @"\Icons\"))
                Directory.CreateDirectory(dirName + @"\Icons\");
        }

        private List<string> ReadConfig(string filePath)
        {
            List<string> lines = new List<string>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    lines.Add(sr.ReadLine());
                }

                if (sr != null)
                    sr.Dispose();
            }
            return lines;
        }

        public List<Location> GetLocations()
        {
            List<Location> locations = new List<Location>();

            foreach (string line in ReadConfig(dirName + locatationsFile))
            {
                locations.Add(GetLocationFromString(line));
            }

            return locations;
        }

        private void WriteDefaultValues()
        {
            SaveConfig(dirName + appSettingsFile, "Background:255;255;255;255;", false);
            SaveConfig(dirName + appSettingsFile, "API Key: \"\"", true);
        }

        private Color GetColorFromString(string s)
        {
            StringBuilder sb = new StringBuilder();
            int A = 255;
            int R =255;
            int B = 255;
            int G = 255;
            int semicolonCount = 0;
            for (int i = 11; i < s.Length; i++)
            {
                if (s[i] != ';')
                    sb.Append(s[i]);
                else
                {
                    semicolonCount++;
                    switch (semicolonCount)
                    {
                        case 1:
                            A = Convert.ToInt32(sb.ToString());
                            sb.Clear();
                            break;
                        case 2:
                            R = Convert.ToInt32(sb.ToString());
                            sb.Clear();
                            break;
                        case 3:
                            G = Convert.ToInt32(sb.ToString());
                            sb.Clear();
                            break;
                        case 4:
                            B = Convert.ToInt32(sb.ToString());
                            sb.Clear();
                            break;
                    }
                }   
            }
            return Color.FromArgb(A,R, G, B);
        }

        private Location GetLocationFromString(string locationString)
        {
            StringBuilder sb = new StringBuilder();
            int semicolonCount = 0;
            Location location = new Location();

            for (int i = 0; i < locationString.Length; i++)
            {
                if (locationString[i] != ';')
                    sb.Append(locationString[i]);
                else
                {
                    semicolonCount++;
                    switch (semicolonCount)
                    {
                        case 1:
                            location.Latitude = (float)Convert.ToDouble(sb.ToString());
                            break;
                        case 2:
                            location.Longitude = (float)Convert.ToDouble(sb.ToString());
                            break;
                        case 3:
                            location.Name = sb.ToString();
                            break;
                        case 4:
                            location.Continent = sb.ToString();
                            break;
                        case 5:
                            location.Country = sb.ToString();
                            break;
                        case 6:
                            location.Region = sb.ToString();
                            break;
                    }
                    sb.Clear();
                }
            }
            return location;
        }

        private string ConverToString(List<string> lines)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string line in lines)
            {
                sb.AppendLine(line);
            }
            return sb.ToString();
        }

        public Color GetColor()
        {
            List<string> lines = ReadConfig(dirName + appSettingsFile);
            foreach (string line in lines)
            {
                if (line.Contains("Background"))
                {
                    Color color = GetColorFromString(line);
                    return GetColorFromString(line);
                }
            }
            return Color.FromArgb(255,255, 255, 255);
        }

        public void AddColorTheme(Color color)
        {
            List<string> lines = ReadConfig(dirName + appSettingsFile);

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains("Background:"))
                {
                    lines.RemoveAt(i);
                    lines.Add($"Background:{color.A};{color.R};{color.G};{color.B};");
                }
            }
            SaveConfig(dirName + appSettingsFile, ConverToString(lines), false);
        }

        public void SaveConfig(string filePath, string content, bool append)
        {
            using (StreamWriter sw = new StreamWriter(filePath, append))
            {
                sw.WriteLine(content);
                if (sw != null)
                    sw.Dispose();
            }
        }

        public void SaveLocation(Location location, bool append)
        {
            string locationSerialize = $"{location.Latitude};{location.Longitude};{location.Name};{location.Continent};{location.Country};{location.Region};" + Environment.NewLine;
            SaveConfig(dirName + locatationsFile, locationSerialize, append);
        }

        public void RemoveLocation(int index)
        {
            List <Location> locations = GetLocations();
            locations.RemoveAt(index);

            bool append = false;

            if (locations.Count == 0)
                SaveConfig(dirName + locatationsFile, string.Empty, false);

            foreach (Location location in locations)
            {
                SaveLocation(location, append);
                append = true;
            }
        }

        public string GetApiKey()
        {
            List<string> lines = ReadConfig(dirName + appSettingsFile);
            string line = lines.FirstOrDefault(l => l.Contains("API Key"));
            string apiKey = line.Split(':')[1];
            apiKey = apiKey.Replace('"', ' ').Trim();
            Debug.WriteLine(apiKey);
            return apiKey;
        }
    }
}
