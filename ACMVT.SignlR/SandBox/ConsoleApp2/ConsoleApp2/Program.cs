using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            IHubProxy hub;
            string url = @"http://localhost:51787/";
            var connection = new HubConnection(url);
            hub = connection.CreateHubProxy("ChatHub");
            connection.Start().Wait();

            hub.On<string, string>("addNewMessageToPage", (n, x) => Console.WriteLine($"{n}: {x}"));

            string text;
            do
            {
                text = Console.ReadLine();
                if (text != "exit")
                {
                    hub.Invoke("Send", "Console", text);
                }
            } while (text != "exit");
        }
    }
}
