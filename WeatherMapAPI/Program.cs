using Newtonsoft.Json.Linq;

namespace WeatherMapAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var weatherURL = "https://api.openweathermap.org/data/2.5/weather?q=London&appid=bff200da1d31b961f942cefd6c219f8d&units=imperial";
            var response = client.GetStringAsync(weatherURL).Result;

            JObject weatherObject = JObject.Parse(response);

            Console.WriteLine("The following is the weather information for London");
            Console.WriteLine($"The temperature is {weatherObject["main"]["temp"]}"); 
           


        }
    }
}