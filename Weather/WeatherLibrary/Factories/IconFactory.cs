using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary.Factories
{
    public class IconFactory
    {
        private static string dirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Weather\Icons\");
        public static Stream GetIcon(string name)
        {
            foreach (string file in Directory.GetFiles(dirPath))
            {
                if (file.Contains(name))
                {
                    byte[] content = File.ReadAllBytes(file);
                    return new MemoryStream(content);
                }
            }
            return null;
        }

        public static Dictionary<string, byte[]> GetIcons()
        {
            Dictionary<string, byte[]> icons = new Dictionary<string, byte[]>();
            foreach (string file in Directory.GetFiles(dirPath))
            {
                string name = new FileInfo(file).Name;
                byte[] content = File.ReadAllBytes(file);
                icons.Add(name, content);
            }
            return icons;
        }
    }

}
