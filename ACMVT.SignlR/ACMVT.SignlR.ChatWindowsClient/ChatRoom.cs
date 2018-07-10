using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMVT.SignlR.ChatWindowsClient
{
    public class ChatRoom
    {
        private readonly string room;
        private readonly string user;
        private readonly IHubProxy hub;

        public delegate void OnMessageRecived(string name, string msg);
        public event OnMessageRecived MessageRecived;
        public event OnMessageRecived PrivateMessageRecived;

        public ChatRoom(IHubProxy hub, string userName, string roomName)
        {
            this.room = roomName;
            this.user = userName;
            this.hub = hub;

            // broadcast
            this.hub.On<string, string>(nameof(EnumAcciones.Broadcast), 
                (n, m) => MessageRecived?.Invoke(n, m)
            );

            this.hub.On<string, string>(nameof(EnumAcciones.SendRoom),
                (n, m) => MessageRecived?.Invoke(n, m)
            );

            this.hub.On<string, string>(nameof(EnumAcciones.SendPrivate),
                (n, m) => PrivateMessageRecived?.Invoke(n, m)
            );
        }

        public void Send(string msg)
        {
            hub.Invoke(nameof(EnumAcciones.SendRoom), room, user, msg);
        }

    }
}
