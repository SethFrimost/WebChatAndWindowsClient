using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;
namespace ACMVT.SignlR.ChatWindowsClient
{
    public class ChatClient
    {
        private readonly string serverUrl;
        IHubProxy hub;
        HubConnection hubConnection;

        private string room;
        public string Room
        {
            get { return room; }
            set {

                // leave room

                // set room
                room = value;

                // join room
                JoinRoom();
            }
        }

        public ChatClient(string serverUrl)
        {
            this.serverUrl = serverUrl;
            hubConnection = new HubConnection(serverUrl);
        }


        private void JoinRoom()
        {
            if (hubConnection == null) throw new Exception("No connexion");
            if (string.IsNullOrWhiteSpace(room)) throw new Exception("Romm is not valid");

            hub = hubConnection.CreateHubProxy(room);
        }


        private void Send(string name, string msg)
        {
            if (hub == null) throw new Exception("No room connexion");

        }
    }
}
