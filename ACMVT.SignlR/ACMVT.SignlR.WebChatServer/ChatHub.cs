using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ACMVT.SignlR.WebChatServer
{
    public class ChatHub : Hub
    {
        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }

        public ChatHub() : base()
        {
            Groups = new RoomManager();
        }
        
        public void Send(string user, string msg)
        {
            Clients.All.broadcast(user, msg);
        }

        public void SendRoom(string room, string user, string msg)
        {
            Clients.Clients((Groups as RoomManager).GetAllConnectionsId(room)).SendRoom(user, msg);
        }

        public void SendPrivate(string user, string msg, string destinationUser)
        {
            var dest = Clients.Client(destinationUser);
            if(dest != null)
            {
                dest.SendPrivate(user, msg);
            }
        }

    }
}