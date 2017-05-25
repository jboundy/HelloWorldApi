using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HelloWorldClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:58146/api/"),
                DefaultRequestHeaders = { Accept = { new MediaTypeWithQualityHeaderValue("text/plain") } }
            };

            var getRequest = GetHelloWorld(client);
            Console.WriteLine(getRequest);
            Console.ReadLine();
        }

        private static string GetHelloWorld(HttpClient client)
        {
            var data = client.GetStringAsync("helloworld").Result;
            return data;
        }
    }
}
