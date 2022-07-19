using Newtonsoft.Json;
using System.Net;

namespace Weather.CLI
{

    internal class Program
    {
        static void Main(string[] args)
        {
            const string apiKey = "your api_key here";

            Console.WriteLine("Digita uma cidade: \n");
            string name = Console.ReadLine();
            Console.WriteLine("");


            var url = WebRequest.Create($"https://api.openweathermap.org/data/2.5/weather?q={name}&units=metric&appid={apiKey}");
            url.Method = "GET";

            HttpWebResponse httpWebResponse = (HttpWebResponse)url.GetResponse();

            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

            var data = DateTime.Now;
            var formatada = String.Format("{0:dd/mm/yyyy hh:MM:ss}", data);
            Console.WriteLine($"Tempo atual em {weatherResponse.Name} - {formatada}");
            Console.WriteLine($"País: {weatherResponse.Sys.Country}");
            Console.WriteLine($"Temperatura atual: {weatherResponse.Main.Temp} Celsius");
            Console.WriteLine($"Temperatura mínima: {weatherResponse.Main.Temp_min} Celsius");
            Console.WriteLine($"Temperatura máxima: {weatherResponse.Main.Temp_max} Celsius");
            Console.WriteLine($"Umidade: {weatherResponse.Main.Humidity} %");

            Console.ReadLine();


        }
    }
}