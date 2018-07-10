using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACMVT.SignlR.ChatWindowsClient;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IHubProxy hub;
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
            */

            var chat = new ChatClient("http://localhost:53237/", "Console");
            chat.rooms[ChatClient.GlobalRoom].MessageRecived += General_MessageRecived;
            chat.rooms[ChatClient.GlobalRoom].PrivateMessageRecived += General_PrivateMessageRecived;

            string text;
            do
            {
                text = Console.ReadLine();
                if (text != "exit")
                {
                    chat.rooms[ChatClient.GlobalRoom].Send(text);
                }
            } while (text != "exit");
        }

        private static void General_MessageRecived(string name, string msg)
        {
            Console.Write($"[1m{name}[0m: {msg}");
        }

        private static void General_PrivateMessageRecived(string name, string msg)
        {
            Console.Write($"[31private => [1m{name}[0m[0m: {msg}");
        }
    }
}
