using Microsoft.Owin.Hosting;

namespace OwinTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            const string uri = "http://localhost:8080/";

            WebApp.Start<Startup>(uri);

            System.Console.ReadLine();
        }
    }
}
