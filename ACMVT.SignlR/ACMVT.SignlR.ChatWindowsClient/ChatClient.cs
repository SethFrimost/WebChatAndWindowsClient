﻿using System;
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
        public const string GlobalRoom = "Global";

        HubConnection hubConnection;
        IHubProxy hub;
        public readonly Dictionary<string, ChatRoom> rooms = new Dictionary<string,ChatRoom>();
        
        public ChatClient(string serverUrl, string userName)
        {
            this.serverUrl = serverUrl;
            this.user = userName;
            hubConnection = new HubConnection(serverUrl);
            hub = hubConnection.CreateHubProxy("ChatHub");
            hubConnection.Start().Wait();
            hub.Invoke(nameof(EnumAcciones.setName), userName);

            JoinRoom(GlobalRoom);
        }

        private void JoinRoom(string room)
        {
            if (hubConnection == null) throw new Exception("No connexion");
            if (string.IsNullOrWhiteSpace(room)) throw new Exception("Romm is not valid");

            rooms.Add(room, new ChatRoom(hub, user,room));
        }

    }
}
