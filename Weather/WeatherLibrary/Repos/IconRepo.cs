using System.IO;

namespace WeatherLibrary.Factories
{
    public class IconRepo
    {
        public static Stream GetIcon(string name)
        {
            return new MemoryStream((byte[])Icons.ResourceManager.GetObject(name));
        }
    }

}
