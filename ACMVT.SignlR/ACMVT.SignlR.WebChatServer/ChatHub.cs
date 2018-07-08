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

        public void Send(string user, string msg)
        {
            
        }

        public void SendPrivate(string user, string msg, string destinationUser)
        {
            var dest = Clients.Client(destinationUser);
            if(dest != null)
            {
                dest.privateMessage(user, msg);
            }
        }
    }
}