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
        private readonly string user;
        private const string GlobalRoom = "Global";

        HubConnection hubConnection;
        public readonly Dictionary<string, ChatRoom> rooms = new Dictionary<string,ChatRoom>();
        
        public ChatClient(string serverUrl, string userName)
        {
            this.serverUrl = serverUrl;
            this.user = userName;
            hubConnection = new HubConnection(serverUrl);
            hubConnection.Start().Wait();
            JoinRoom(GlobalRoom);
        }


        private void JoinRoom(string room)
        {
            if (hubConnection == null) throw new Exception("No connexion");
            if (string.IsNullOrWhiteSpace(room)) throw new Exception("Romm is not valid");
        }

    }
}
