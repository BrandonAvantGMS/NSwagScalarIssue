using System;
using System.Threading.Tasks;
using Producer.ApiClient;

namespace Consumer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ProducerApiClient api = new ProducerApiClient("http://localhost:5000", new System.Net.Http.HttpClient());

            var result = await api.WeatherForecast_GetAsync();

            Console.WriteLine(result);
        }
    }
}
