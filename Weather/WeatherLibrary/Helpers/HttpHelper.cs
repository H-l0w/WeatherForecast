using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace WeatherLibrary.Helpers
{
    public class HttpHelper
    {
        private static readonly Lazy<HttpHelper> helper =
            new Lazy<HttpHelper>(() => new HttpHelper());

        public static HttpHelper Instance { get { return helper.Value; } }

        private HttpHelper()
        {
        }

        public async Task<string> SendRequest(string url)
        {
            HttpClient http = new HttpClient();

            string response = await Task.Run(() => http.GetStringAsync(url));

            string data = response.ToString();

            return data;
        }
    }
}
