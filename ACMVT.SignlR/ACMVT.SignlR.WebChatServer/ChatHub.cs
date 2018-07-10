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
        static Dictionary<string, string> UserNames;
        

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


        public void SetName(string name)
        {
            if (UserNames == null) UserNames = new Dictionary<string, string>();

            //this.Context.User.Identity.Name = name;

            if (UserNames.ContainsKey(Context.ConnectionId))
            {
                UserNames[Context.ConnectionId] = name;
            }
            else
            {
                UserNames.Add(Context.ConnectionId, name);
            }
        }
        
        private string GetUserName()
        {
            if (UserNames.ContainsKey(Context.ConnectionId))
            {
                return UserNames[Context.ConnectionId];
            }
            else
            {
                return Context.ConnectionId;
            }
        }


        public void JoinRoom(string room)
        {
            Groups.Add(Context.ConnectionId, room);
        }

        public void LeaveRoom(string room)
        {
            Groups.Remove(Context.ConnectionId, room);
        }


        public void SendAll(string msg)
        {
            Clients.All.broadcast(GetUserName(), msg);
        }

        public void SendRoom(string room, string msg)
        {
            Clients.OthersInGroup(room).sendRoom(GetUserName(), msg);
        }

        public void SendPrivate(string msg, string destinationUser)
        {
            var dest = Clients.Client(destinationUser);
            if(dest != null)
            {
                dest.sendPrivate(GetUserName(), msg);
            }
        }

    }
}